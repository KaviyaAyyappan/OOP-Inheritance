using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList rnd = new RandomList();
            rnd.Add("jack");
            rnd.Add("Rose");
            rnd.Add("emil");
            rnd.RandomString();
            for (int i = 0; i < rnd.Count; i++)
            {
                Console.WriteLine(rnd[i]);
            }
            Console.ReadLine();
        }
    }
}
