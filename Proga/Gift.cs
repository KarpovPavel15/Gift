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
            List<Fruit> fruit = new List<Fruit>();
            fruit.Add(new Fruit("Orange", 180, 100, 100, 0, 0));
            fruit.Add(new Fruit("Pineapple", 20, 190, 100, 0, 0));
            fruit.Add(new Fruit("Apple", 100, 299, 200, 80, 0));
            fruit.Add(new Fruit("Banana", 301, 199, 300, 80, 0));

            List<Wafer> wafer = new List<Wafer>();
            wafer.Add(new Wafer("Kroket", 212, 761, 200, "chocolate", 0));
            wafer.Add(new Wafer("Spartak", 17, 1761, 200, "milk", 0));
            wafer.Add(new Wafer("Slodch", 310, 61, 200, "fruits", 0));
            wafer.Add(new Wafer("Vitba", 15, 77, 200, "cream", 0));

            List<Candy> candy = new List<Candy>();
            candy.Add(new Candy("Cow", 22, 123, 200, 200, "chocolate"));
            candy.Add(new Candy("Bee", 17, 77631, 200, 200, "glazyr"));
            candy.Add(new Candy("Kuzn", 30, 71, 200, 200, "konyak"));
            candy.Add(new Candy("Gryliazh", 15, 773, 200, 200, "cream"));

            List<Sweet> swt1 = new List<Sweet>();
            swt1.AddRange(fruit);
            swt1.AddRange(wafer);
            swt1.AddRange(candy);
            JSON.SerializationSweet(swt1);

            List<Sweet> gft = new List<Sweet>();
            gft = JSON.DeserializationSweet();

          
            int j = 0;
            for (int i = 0; i < gft.Count; i++)
            {
                if (gft[i].contain("fruit")) j++;
            }
            Console.WriteLine(j);


            int summWeight = 0;
            for (int i = 0; i < gft.Count; i++) 
            {
                summWeight += gft[i].Weight;
            }
            Console.WriteLine(summWeight);

            //gft.Sort();
            //Show.outputinfo(gft);

        }
    }
}
