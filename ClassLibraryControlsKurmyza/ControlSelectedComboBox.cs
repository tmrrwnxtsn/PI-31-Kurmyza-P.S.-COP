using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ClassLibraryControlsKurmyza
{
    public partial class ControlSelectedComboBox : UserControl
    {
        private event EventHandler _comboBoxSelectedElementChange;

        [Category("Свойства comboBox"), Description("Ссылка на свойство Items comboBox")]
        public ComboBox.ObjectCollection Items { get { return this.comboBox.Items; } }

        public ControlSelectedComboBox()
        {
            InitializeComponent();
            comboBox.SelectedIndexChanged += (sender, e) => _comboBoxSelectedElementChange?.Invoke(sender, e);
        }

        /// <summary>
        /// Метод очищения списка comboBox
        /// </summary>
        public void ClearItems()
        {
            comboBox.Items.Clear();
            comboBox.Text = string.Empty;
        }

        /// <summary>
        /// Метод добавления элемента в список comboBox. Если добавляемый элемент уже существует, он выделяется.
        /// </summary>
        public void AddItem(string item)
        {
            if (comboBox.Items.Contains(item))
            {
                comboBox.SelectedItem = item;
            }
            else
            {
                comboBox.Items.Add(item);
            }
        }

        [Category("Свойства comboBox"), Description("Выбранный элемент")]
        public string SelectedItem
        {
            get => comboBox.SelectedItem == null ? string.Empty : comboBox.SelectedItem.ToString();
            set => comboBox.SelectedItem = value;

        }

        [Category("События comboBox"), Description("Событие выбора элемента из списка")]
        public event EventHandler ComboBoxSelectedElementChange
        {
            add { _comboBoxSelectedElementChange += value; }
            remove { _comboBoxSelectedElementChange -= value; }
        }
    }
}
