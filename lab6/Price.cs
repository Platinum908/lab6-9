using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Price
    {
        public string name { get; set; }
        public int cost { get; set; }

        public Price(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
