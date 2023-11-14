using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{


    internal class Item
    {

        public string Name { get; }
        public string Display_Equips { get; set; }
        public string Stat { get; }
        public int Add_stat { get; }
        public string Ex { get; }
        public bool Equips { get; set; }
        public int Price { get; }

        public Item(string name,string display_eq, string stat, int add_stat, string ex, bool equips, int price)
        {
            Name = name;
            Display_Equips = display_eq;
            Stat = stat;
            Add_stat = add_stat;
            Ex = ex;
            Equips = equips;
            Price = price;
        }
    }
}
