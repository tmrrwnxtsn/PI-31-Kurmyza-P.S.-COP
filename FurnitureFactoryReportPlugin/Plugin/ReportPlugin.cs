using ClassLibraryComponentsKurmyza.HelperModels;
using ClassLibraryComponentsKurmyza;
using FurnitureFactoryBusinessLogic.BusinessLogics;
using FurnitureFactoryBusinessLogic.HelperModels;
using FurnitureFactoryDatabaseImplement.BindingModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using WindowsFormsComponentsAbanin;
using ComponentLibrary.models;
using ComponentLibrary;
using WindowsFormsComponentLibrary;
using WindowsFormsComponentLibrary.Models;
using FurnitureFactoryDatabaseImplement.ViewModels;
using PluginConventionTools.Interfaces;
using PluginConventionTools.Models;

namespace FurnitureFactoryReportPlugin.Plugin
{
    [Export(typeof(IPluginsConvention))]
    public class ReportPlugin : IPluginsConvention
    {
        private readonly ContextMenuStrip _menu = new ContextMenuStrip();

        private TreeUserControl _treeUserControl;

        private readonly ComponentExcelTable _componentExcelTable = new ComponentExcelTable();

        private readonly ComponentContextBigText _componentContextBigText = new ComponentContextBigText();

        private readonly DocWithDiagram _componentDiagramPdf = new DocWithDiagram();
            
        private readonly SupplierLogic _supplierLogic = new SupplierLogic();
        
        private readonly ReportLogic _reportLogic = new ReportLogic();

        public ReportPlugin()
        {
            var bookShapeMenuItem = new ToolStripMenuItem("Тип поставщика");
            _menu.Items.Add(bookShapeMenuItem);
            bookShapeMenuItem.Click += (sender, e) =>
            {
                var formOrganizationTypes = new FormOrganizationTypes();
                formOrganizationTypes.ShowDialog();
            };
            ReloadData();
        }
       
        public void ReloadData()
        {
            _treeUserControl = new TreeUserControl
            {
                Dock = DockStyle.Fill,
                ContextMenuStrip = _menu,
            };
            _treeUserControl.SetHierarchy(new List<string> { "OrganizationType", "LastDelivery", "Id", "Name" });

            try
            {
                var list = _supplierLogic.Read(null);
                foreach (var supplier in list)
                {
                    _treeUserControl.AddItem(supplier, "Name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string PluginName
        {
            get
            {
                return "Поставщики";
            }
        }
        public UserControl GetControl
        {
            get
            {
                return _treeUserControl;
            }
        }

        public PluginsConventionElement GetElement
        {
            get
            {
                return _treeUserControl.GetSelectedItem<PluginsConventionElement>();
            }
        }
        public bool DeleteElement(PluginsConventionElement element)
        {
            var selectedItem = _treeUserControl.GetSelectedItem<SupplierStringModel>();
            if (selectedItem is null || string.IsNullOrEmpty(selectedItem.Name) || selectedItem.Id == 0)
            {
                return false;
            }

            if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(_treeUserControl.GetSelectedItem<SupplierStringModel>()?.Id);
                try
                {
                    _supplierLogic.Delete(new SupplierBindingModel() { Id = id });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                ReloadData();
                return true;
            }
            return false;
        }

        public Form GetForm(PluginsConventionElement element)
        {
            var selectedItem = _treeUserControl.GetSelectedItem<SupplierStringModel>();
            FormSupplier formSupplier = new FormSupplier();
            if (element != null)
            {
                formSupplier.SupplierStringModel = selectedItem;
            }
            return formSupplier;
        }

        [Obsolete]
        public bool CreateSimpleDocument(PluginsConventionSaveDocument saveDocument)
        {

            if (string.IsNullOrEmpty(saveDocument.FileName))
            {
                MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_componentContextBigText.CreateDocument(new ContentParameters()
            {
                Path = saveDocument.FileName,
                Title = "Отчет по поставщикам в этом году",
                ArrayText = _reportLogic.GetArraySupplierWithManufacturedFurnitureForYear()
            }))
            {
                MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(_componentContextBigText.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CreateTableDocument(PluginsConventionSaveDocument saveDocument)
        {
            if (string.IsNullOrEmpty(saveDocument.FileName))
            {
                MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var tableDataConfig = _reportLogic.GetSupplierForTable();
                if (_componentExcelTable.CreateDoc(new ExcelTableConfig<SupplierViewModel>
                {
                    FileName = saveDocument.FileName,
                    Data = tableDataConfig.Data,
                    Headers = tableDataConfig.Headers,
                    RowsHeight = tableDataConfig.RowsHeight,
                    Title = "Отчет по поставщикам",
                    PropertiesOrder = tableDataConfig.PropertiesOrder,
                    ColumnsWidth = tableDataConfig.ColumnsWidth

                }))
                {
                    MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(_componentContextBigText.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool CreateChartDocument(PluginsConventionSaveDocument saveDocument)
        {
            if (string.IsNullOrEmpty(saveDocument.FileName))
            {
                MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var list = _reportLogic.GetListSuppliersCount();
                _componentDiagramPdf.GenerateDoc(new DiagramInfo
                {
                    ChartHeader = "Типы организаций и количество",
                    Header = "Отчет по поставщикам в разрезе типов организации за год",
                    FilePath = saveDocument.FileName,
                    Items = list
                });
                MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
