using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Companion companion = new Companion();
            string words = Console.ReadLine();
            Console.WriteLine(companion.getWords(words));

            Console.ReadLine();
        }
    }
}
