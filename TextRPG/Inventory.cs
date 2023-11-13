using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{


    internal class Inventory
    {

        public string Name { get; }
        public string Stat { get; }
        public int Add_stat { get; }
        public string Ex { get; }

        public Inventory(string name, string stat, int add_stat, string ex)
        {
            Name = name;    
            Stat = stat;    
            Add_stat = add_stat;   
            Ex = ex;   
        }
    }
}
