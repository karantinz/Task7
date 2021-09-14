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
            string userMessage;
            int HowMuchToRepeat;

            Console.WriteLine("Введите сообщение");
            userMessage = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Сколько раз оно должно повторяться?");
            HowMuchToRepeat = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < HowMuchToRepeat; i++)
            {
                Console.WriteLine(userMessage);                
            }
            Console.ReadKey();
        }
    }
}
