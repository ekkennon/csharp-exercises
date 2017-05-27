using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public static int nextCheeseId = 0;
        public int CheeseId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public Cheese()
        {
            CheeseId = nextCheeseId;
            nextCheeseId++;
        }
    }
}
