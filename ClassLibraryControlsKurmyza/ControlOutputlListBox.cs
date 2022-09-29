﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassLibraryControlsKurmyza
{
    public partial class ControlOutputlListBox : UserControl
    {
        private ControlOutputListBoxLayout layout = null;
        public ControlOutputlListBox()
        {
            InitializeComponent();
        }

        [Category("Свойства listBox"), Description("Индекс выбранной строки")]
        public int SelectedIndex
        {
            get => listBox.SelectedIndex;
            set
            {
                if (value >= -1 && value < listBox.Items.Count)
                    listBox.SelectedIndex = value;
            }
        }

        /// <summary>
        /// Установка макета
        /// </summary>
        /// <param name="layout"></param>
        public void SetLayout(ControlOutputListBoxLayout layout)
        {
            if (layout != null) this.layout = layout;
        }

        /// <summary>
        /// Получение элемента T из выбранной в listBox строки
        /// </summary>
        /// <typeparam name="T">Тип элемента, значения которого написанны в выбранной строке</typeparam>
        /// <returns>Элемент типа Т со значениями из выбранной строки</returns>
        public T GetSelectedItem<T>() where T : class, new()
        {
            T restoreItem;
            if (listBox.SelectedIndex != -1 && layout != null)
            {
                T itemT = Activator.CreateInstance<T>();
                string mask = layout.Layout;
                string selectedItemString = listBox.SelectedItem.ToString();
                string regPropertyName = layout.PatternProperty;
                string[] simpleText = Regex.Split(mask, regPropertyName);
                var propertiesWithSigns = Regex.Matches(mask, regPropertyName);
                for (int i = 0; i < simpleText.Length - 1; i++)
                {
                    int lengthBefore = simpleText[i].Length;
                    string propertyName = layout.GetPropertyName(propertiesWithSigns[i].Value);
                    int indexAfter = selectedItemString.IndexOf(simpleText[i + 1]);
                    string propertyValue;
                    if (indexAfter == 0)
                    {
                        propertyValue = selectedItemString.Substring(lengthBefore);
                    }
                    else
                    {
                        propertyValue = selectedItemString.Substring(lengthBefore, indexAfter - lengthBefore);
                        selectedItemString = selectedItemString.Substring(indexAfter);
                    }

                    var property = itemT.GetType().GetProperty(propertyName);
                    if (property != null && propertyValue != layout.StartSign + propertyName + layout.EndSign)
                    {
                        var propertyInfo = property;
                        var propertyType = property?.PropertyType;
                        propertyInfo.SetValue(itemT, Convert.ChangeType(propertyValue, propertyType));
                    }
                }
                restoreItem = itemT;
            }
            else
            {
                restoreItem = default;
            }
            return restoreItem;
        }

        /// <summary>
        /// Метод заполнения значений строк в listBox
        /// </summary>
        /// <typeparam name="T">Тип элемента</typeparam>
        /// <param name="itemObject">Элемент, из которого необходимо получить значение свойства</param>
        /// <param name="rowIndex">Индекс строки</param>
        /// <param name="propertyName">Название свойства, значение которого необходимо записать</param>
        public void Insert<T>(T itemObject, int rowIndex, string propertyName)
        {
            if (!string.IsNullOrEmpty(propertyName) && itemObject != null && layout != null)
            {
                var properties = Regex.Matches(layout.Layout, layout.PatternProperty);
                string propertyWithSigns = layout.StartSign + propertyName + layout.EndSign;
                var findedPropertyWithSigns = properties
                    .Cast<Match>()
                    .FirstOrDefault(prop => prop.Value.Equals(propertyWithSigns));
                if (findedPropertyWithSigns != null)
                {
                    string valueString;
                    while (listBox.Items.Count <= rowIndex)
                    {
                        listBox.Items.Add(layout.Layout);
                    }
                    var items = listBox.Items;
                    string ItemString = listBox.Items[rowIndex].ToString();
                    var property = itemObject.GetType().GetProperty(propertyName);
                    if (property != null)
                    {
                        var propertyValue = property.GetValue(itemObject, null);
                        valueString = propertyValue?.ToString();
                    }
                    else
                    {
                        valueString = null;
                    }
                    items[rowIndex] = ItemString.Replace(propertyWithSigns, valueString);
                }
            }
        }
    }
}
