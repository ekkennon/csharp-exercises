namespace Restaurant
{
    class MenuItem
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Category { get; set; }//appetizer, dessert, main course
        public bool IsNew { get; set; }

        public MenuItem(string name, string desc, string cat, double price)
        {
            Price = price;
            Name = name;
            Desc = desc;
            Category = cat;
            IsNew = true;
        }

        public override string ToString()
        {
            return Name + " $" + Price;
        }
    }
}
