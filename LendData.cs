using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace RentACable
{
    public class LendData
    {
        public readonly List<Item> Items = new List<Item>();
        public readonly List<LendEntry> LendEntries = new List<LendEntry>();
        public readonly HashSet<string> AllLabels = new HashSet<string>();
        public readonly HashSet<string> AllPersonNames = new HashSet<string>();
        public int BiggestItemID = 0;

        public static LendData Load(JObject values)
        {
            LendData data = new LendData();

            // Load items
            var itemValues = values["items"];
            if (itemValues != null)
            {
                foreach (var itemData in itemValues)
                {
                    var loadedItem = new Item()
                    {
                        Id = (int)itemData["id"],
                        Label = (string)itemData["label"],
                        Name = (string)itemData["name"],
                    };
                    data.Items.Add(loadedItem);
                }
            }

            // Load entries
            var entryValues = values["entries"];
            if (entryValues != null)
            {
                foreach (var entryData in entryValues)
                {
                    var loadedEntry = new LendEntry()
                    {
                        PersonName = (string)entryData["person_name"],
                        ItemId = (int)entryData["item_id"],
                    };
                    data.LendEntries.Add(loadedEntry);
                }
            }

            data.UpdateCaches();
            return data;
        }

        public JObject Save()
        {
            var values = new JObject();
            var itemsList = new JArray();
            foreach (var item in Items)
            {
                var itemData = new JObject
                {
                    ["id"] = item.Id,
                    ["name"] = item.Name,
                    ["label"] = item.Label
                };
                itemsList.Add(itemData);
            }
            values["items"] = itemsList;

            var entryList = new JArray();
            foreach (var entry in LendEntries)
            {
                var itemData = new JObject
                {
                    ["item_id"] = entry.ItemId,
                    ["person_name"] = entry.PersonName
                };
                entryList.Add(itemData);
            }
            values["entries"] = entryList;

            return values;
        }

        public void UpdateCaches()
        {
            AllLabels.Clear();
            AllPersonNames.Clear();
            foreach (var item in Items)
            {
                AllLabels.Add(item.Label);
                if (item.Id > BiggestItemID) BiggestItemID = item.Id;
            }
            foreach (var item in LendEntries)
                AllPersonNames.Add(item.PersonName);
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
    }

    public class LendEntry
    {
        public int ItemId { get; set; }
        public string PersonName { get; set; }
    }
}
