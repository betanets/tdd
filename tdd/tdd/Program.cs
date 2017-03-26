using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------============Консольный друг============-----------");
            Console.WriteLine(">>> Напиши мне что-нибудь!");
            Companion companion = new Companion();
            string words;
            do
            {
                words = Console.ReadLine();
                Console.WriteLine(companion.getWords(words));
            } while (words != "Пока");

            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine("[!!!!!!] До завершения работы " + i);
                Thread.Sleep(1000);
            }
        }
    }
}
