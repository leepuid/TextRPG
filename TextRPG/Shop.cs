using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Shop
    {
        public string Name { get; }
        public string Stat { get; }
        public int Add_stat { get; }
        public string Ex { get; }
        public int Price { get; set; }
        public bool Display_buy { get; set; }
        public string Buy_comple { get;  set; }

        public Shop(string name, string stat, int add_stat, string ex, int price, bool display_buy, string buy_comple)
        {
            Name = name;
            Stat = stat;
            Add_stat = add_stat;
            Ex = ex;
            Price = price;
            Display_buy = display_buy;
            Buy_comple = buy_comple;
        }
    }
}
