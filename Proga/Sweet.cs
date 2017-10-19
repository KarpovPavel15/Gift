using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Sweet
    {
        public Sweet(string name, int weight, int calories, int cost)
        {
            Name = name;
            Weight = weight;
            Calories = calories;
            Cost = cost;
        }

        public string Name { get; set; }

        public int Weight { get; set; }

        public int Calories { get; set; }

        public int Cost { get; set; }

    }
}
