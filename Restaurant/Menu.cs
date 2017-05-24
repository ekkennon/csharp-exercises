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
    }
}
