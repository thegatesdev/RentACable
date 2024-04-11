using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Markup;

namespace RentACable.Views
{
    public partial class HomeForm : Form
    {
        private LendData _lendData;

        public HomeForm(LendData lendData)
        {
            _lendData = lendData;
            _lendData.UpdateCaches();

            InitializeComponent();
            InitializeEvents();
            UpdateContent(_lendData);
        }

        private void InitializeEvents()
        {
            InitializeNavigation();
            itemsGrid.RowLeave += (o, e) => SaveItemsGrid(_lendData);
            lendGrid.RowLeave += (o, e) => SaveLendGrid(_lendData);
            lendGrid.CellEndEdit += (o, e) =>
            {
                SaveLendGrid(_lendData);
                UpdateLendGrid(_lendData);
            };
            itemsGrid.CellEndEdit += (o, e) =>
            {
                SaveItemsGrid(_lendData);
                UpdateItemsGrid(_lendData);
            };
        }

        private void InitializeNavigation()
        {
            // Expect the button controls to be in the same order as the tabs.
            var controls = navLayout.Controls;
            for (int i = 0; i < controls.Count; i++)
            {
                // Copy.. otherwise, i will be hoisted and incremented in the same lambda class.
                int copy = i;
                controls[i].Click += (o, e) => SwitchContentTab(copy);
            }
        }

        private void UpdateContent(LendData data)
        {
            data.UpdateCaches();
            UpdateLabelView(data);
            UpdateItemsGrid(data);
            UpdateLendGrid(data);
        }

        private void UpdateLabelView(LendData data)
        {
            labelList.Clear();
            foreach (var label in data.AllLabels)
                labelList.Items.Add(label);
        }

        private void UpdateItemsGrid(LendData data)
        {
            int existing = itemsGrid.RowCount-1;
            var rows = itemsGrid.Rows;
            for (int i = 0; i < data.Items.Count; i++)
            {
                var item = data.Items[i];
                var values = new object[]
                {
                    item.Id, item.Name, item.Label
                };
                if (i < existing)
                {
                    rows[i].SetValues(values);
                }
                else
                {
                    rows.Add(values);
                }
            }
            itemsGrid.Refresh();
        }

        private void UpdateLendGrid(LendData data)
        {
            int existing = lendGrid.RowCount-1;
            var rows = lendGrid.Rows;
            for (int i = 0; i < data.LendEntries.Count; i++)
            {
                var entry = data.LendEntries[i];
                Item find = entry.ItemId < 0 ? null : data.Items.Find((item) => item.Id == entry.ItemId); ;
                object[] value = new object[]
                {
                    find == null ? "Niet gevonden" : find.Name, entry.PersonName
                };
                if (i < existing)
                    rows[i].SetValues(value);
                else
                    rows.Add(value);
            }
            lendGrid.Refresh();
        }

        private void SaveItemsGrid(LendData data)
        {
            for (int i = 0; i < itemsGrid.RowCount - 1; i++)
            {
                var cells = itemsGrid.Rows[i].Cells;
                if (i < data.Items.Count)
                {
                    data.Items[i].Name = (string)cells[1].Value;
                    data.Items[i].Label = (string)cells[2].Value;
                }
                else
                {
                    int id = ++data.BiggestItemID;
                    data.Items.Add(new Item()
                    {
                        Id = id,
                        Name = (string)cells[1].Value,
                        Label = (string)cells[2].Value,
                    });
                }
            }
        }

        private void SaveLendGrid(LendData data)
        {
            for (int i = 0; i < lendGrid.RowCount - 1; i++)
            {
                var cells = lendGrid.Rows[i].Cells;
                string personNameValue = (string)cells[1].Value;
                object itemValue = cells[0].Value;
                int itemId;
                if (itemValue is string itemValueString)
                {
                    try
                    {
                        itemId = int.Parse(itemValueString);
                    }
                    catch (FormatException)
                    {
                        var find = data.Items.Find((item) => item.Name == itemValueString);
                        itemId = find == null ? -1 : find.Id;
                    }
                }
                else if (itemValue is int itemValueInt)
                {
                    itemId = itemValueInt;
                }
                else
                {
                    itemId = -1;
                }
                if (i < data.LendEntries.Count)
                {
                    data.LendEntries[i].ItemId = itemId;
                    data.LendEntries[i].PersonName = personNameValue;
                }
                else
                {
                    data.LendEntries.Add(new LendEntry()
                    {
                        ItemId = itemId,
                        PersonName = personNameValue,
                    });
                }
            }
        }


        private void SwitchContentTab(int index)
        {
            contentTabs.SelectTab(index);
            SaveItemsGrid(_lendData);
            SaveLendGrid(_lendData);
            UpdateContent(_lendData);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            File.WriteAllText(path + "/lendData.json", _lendData.Save().ToString());
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _lendData = LendData.Load(JObject.Parse(File.ReadAllText(path + "/lendData.json")));
        }
    }
}
