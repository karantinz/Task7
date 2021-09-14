using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int total;

            Console.WriteLine("Введите сообщение");
            userInput = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Сколько раз оно должно повторяться?");
            total = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < total; i++)
            {
                Console.WriteLine(userInput);                
            }
            Console.ReadKey();
        }
    }
}
