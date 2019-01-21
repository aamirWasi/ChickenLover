using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenLover
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int i=0; i<T; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num >= 120)
                {
                    Console.WriteLine("Good Boy Sifat");
                } else
                {
                    Console.WriteLine("Naughty Boy Sifat");
                }
            }

        }
    }
}
