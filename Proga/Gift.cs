using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Gift
    {
        static void Main(string[] args)
        {
            List<Fruit> fruit=new List<Fruit>();
            fruit.Add(new Fruit("Orange", 180, 100, 100, 0, 0));
            fruit.Add(new Fruit("Pineapple", 20, 190, 100, 0, 0));
            fruit.Add(new Fruit("Apple", 100, 299, 200, 80, 0));
            fruit.Add(new Fruit("Banana", 301, 199, 300, 80, 0));

            List<Wafer> wfl = new List<Wafer>();
            wfl.Add(new Wafer("Kroket", 212, 761, 200, "chocolate", 0));
            wfl.Add(new Wafer("Spartak", 17, 1761, 200, "milk", 0));
            wfl.Add(new Wafer("Slodch", 310, 61, 200, "fruits", 0));
            wfl.Add(new Wafer("Vitba", 15, 77, 200, "cream", 0));

            List<Candy> cnd = new List<Candy>();
            cnd.Add(new Candy("Cow", 22, 123, 200, 200, "chocolate"));
            cnd.Add(new Candy("Bee", 17, 77631, 200, 200, "glazyr"));
            cnd.Add(new Candy("Kuzn", 30, 71, 200, 200, "konyak"));
            cnd.Add(new Candy("Gryliazh", 15, 773, 200, 200, "cream"));

        }
    }
}
