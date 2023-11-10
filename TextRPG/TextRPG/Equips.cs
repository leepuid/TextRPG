using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Equips
    {
        public string Name { get; }
        public string Stat { get; }
        public int Add_stat { get; }
        public string Ex { get; }

        public Equips(string name, string stat, int add_stat, string ex)
        {
            Name = name;    //장비 이름
            Stat = stat;    // 장비 추가 스텟 이름
            Add_stat = add_stat;    // 장비 추가 스텟
            Ex = ex;    // 장비 설명
        }

    }
}
