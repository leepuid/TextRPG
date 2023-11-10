using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Inventory
    {
        public int[] Code { get; }

        public string Name { get; }

        public Inventory(int[] code)
        {
            Code = code;
        }

        public void PlayerInven()
        {
            ItemList itemList = new ItemList();
            itemList.ExcelDataLoad();
            for(int i = 0; i < Code.Length; i++)
            {
                for (int j = 0; j < ?; j++)
                {
                    if (Code[i] == ?)
                    {
                        Console.WriteLine("좀 나와줘~~~~");
                    }
                }
            }
        }
    }
}
