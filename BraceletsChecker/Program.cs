using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraceletsChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Give a line with bracelets");
                string line = Console.ReadLine();

                if (Util.CorrectlyFormedBraceletsLine(line))
                {
                    Console.WriteLine("Correctly formed braceletsline");
                }
                else
                {
                    Console.WriteLine("Incorrectly formed braceletsline");
                }
            }
        }
    }
}
