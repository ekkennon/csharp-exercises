using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime Updated { get; set; }
        public string Type { get; set; }//breakfast,lunch,dinner

        public Menu(List<MenuItem> items, DateTime updated, string type)
        {
            Items = items;
            Updated = updated;
            Type = type;
        }

        public Menu(string type) : this(new List<MenuItem>(), DateTime.Now, type)
        {
        }

        public void addItem(MenuItem item)
        {
            Items.Add(item);
        }

        public void removeItem(MenuItem item)
        {
            Items.Remove(item);
        }

        public override string ToString()
        {
            string menu = "";
            foreach (MenuItem item in Items)
            {
                menu += item.ToString() + "\n";
            }
            return menu;
        }
    }
}
