using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harry_pottah_PP_Oppgave
{
    internal class Item
    {
        public string Name;
        public int Cost;
        public string Type;

        public Item(string name, int cost, string type)
        {
           Name = name;
           Cost = cost;
           Type = type;
        }   
    }
}
