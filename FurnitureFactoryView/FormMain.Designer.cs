using System.Windows.Forms;

namespace FurnitureFactoryView
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ControlsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SimpleDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простойДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документСТаблицейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlsStripMenuItem,
            this.ActionsToolStripMenuItem,
            this.DocsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(915, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Меню";
            // 
            // ControlsStripMenuItem
            // 
            this.ControlsStripMenuItem.Name = "ControlsStripMenuItem";
            this.ControlsStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.ControlsStripMenuItem.Text = "Справочники";
            // 
            // ActionsToolStripMenuItem
            // 
            this.ActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddElementToolStripMenuItem,
            this.UpdElementToolStripMenuItem,
            this.DelElementToolStripMenuItem});
            this.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem";
            this.ActionsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.ActionsToolStripMenuItem.Text = "Действия";
            // 
            // AddElementToolStripMenuItem
            // 
            this.AddElementToolStripMenuItem.Name = "AddElementToolStripMenuItem";
            this.AddElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AddElementToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.AddElementToolStripMenuItem.Text = "Добавить";
            this.AddElementToolStripMenuItem.Click += new System.EventHandler(this.AddElementToolStripMenuItem_Click);
            // 
            // UpdElementToolStripMenuItem
            // 
            this.UpdElementToolStripMenuItem.Name = "UpdElementToolStripMenuItem";
            this.UpdElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.UpdElementToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.UpdElementToolStripMenuItem.Text = "Изменить";
            this.UpdElementToolStripMenuItem.Click += new System.EventHandler(this.UpdElementToolStripMenuItem_Click);
            // 
            // DelElementToolStripMenuItem
            // 
            this.DelElementToolStripMenuItem.Name = "DelElementToolStripMenuItem";
            this.DelElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DelElementToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.DelElementToolStripMenuItem.Text = "Удалить";
            this.DelElementToolStripMenuItem.Click += new System.EventHandler(this.DelElementToolStripMenuItem_Click);
            // 
            // DocsToolStripMenuItem
            // 
            this.DocsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SimpleDocToolStripMenuItem,
            this.TableDocToolStripMenuItem,
            this.ChartDocToolStripMenuItem});
            this.DocsToolStripMenuItem.Name = "DocsToolStripMenuItem";
            this.DocsToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.DocsToolStripMenuItem.Text = "Документы";
            // 
            // SimpleDocToolStripMenuItem
            // 
            this.SimpleDocToolStripMenuItem.Name = "SimpleDocToolStripMenuItem";
            this.SimpleDocToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SimpleDocToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.SimpleDocToolStripMenuItem.Text = "Простой документ";
            this.SimpleDocToolStripMenuItem.Click += new System.EventHandler(this.SimpleDocToolStripMenuItem_Click);
            // 
            // TableDocToolStripMenuItem
            // 
            this.TableDocToolStripMenuItem.Name = "TableDocToolStripMenuItem";
            this.TableDocToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.TableDocToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.TableDocToolStripMenuItem.Text = "Документ с таблицой";
            this.TableDocToolStripMenuItem.Click += new System.EventHandler(this.TableDocToolStripMenuItem_Click);
            // 
            // ChartDocToolStripMenuItem
            // 
            this.ChartDocToolStripMenuItem.Name = "ChartDocToolStripMenuItem";
            this.ChartDocToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ChartDocToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.ChartDocToolStripMenuItem.Text = "Диаграмма";
            this.ChartDocToolStripMenuItem.Click += new System.EventHandler(this.ChartDocToolStripMenuItem_Click);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 28);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(915, 452);
            this.panelControl.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.простойДокументToolStripMenuItem,
            this.документСТаблицейToolStripMenuItem,
            this.диаграммаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(277, 148);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // простойДокументToolStripMenuItem
            // 
            this.простойДокументToolStripMenuItem.Name = "простойДокументToolStripMenuItem";
            this.простойДокументToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.простойДокументToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.простойДокументToolStripMenuItem.Text = "Простой документ";
            this.простойДокументToolStripMenuItem.Click += new System.EventHandler(this.простойДокументToolStripMenuItem_Click);
            // 
            // документСТаблицейToolStripMenuItem
            // 
            this.документСТаблицейToolStripMenuItem.Name = "документСТаблицейToolStripMenuItem";
            this.документСТаблицейToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.документСТаблицейToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.документСТаблицейToolStripMenuItem.Text = "Документ с таблицей";
            this.документСТаблицейToolStripMenuItem.Click += new System.EventHandler(this.документСТаблицейToolStripMenuItem_Click);
            // 
            // диаграммаToolStripMenuItem
            // 
            this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
            this.диаграммаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.диаграммаToolStripMenuItem.Text = "Диаграмма";
            this.диаграммаToolStripMenuItem.Click += new System.EventHandler(this.диаграммаToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ControlsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SimpleDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChartDocToolStripMenuItem;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ToolStripMenuItem ActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelElementToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem простойДокументToolStripMenuItem;
        private ToolStripMenuItem документСТаблицейToolStripMenuItem;
        private ToolStripMenuItem диаграммаToolStripMenuItem;
    }
}

