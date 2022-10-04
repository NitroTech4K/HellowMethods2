using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowMethods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods 2.0");

            int score = 0;
            Addscore(100);

                Console.ReadKey(true);
        }

        static void Addscore(int pointsEarned)
        {
            score = score + pointsEarned;
        }
    }
}
