using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lizards
{
    public class UserInteraction
    {
        public void Greetings()
        {
            Console.WriteLine("\t\t\t\t\t\tРУСЫ ПРОТИВ ЯЩЕРОВ\n\n\n\n\n");
        }

        public void StartByUserChoice()
        {
            Console.WriteLine("1.Отправиться в путешествие \n2.Выйти");
            try
            {
                while (true)
                {
                    char choice = Console.ReadKey().KeyChar;
                    switch (choice)
                    {
                        case '1': 

                            Console.WriteLine("\nВы выбрали опцию 1");
                            SlowPrint("Вы проснулись");
                            break;
                        case '2':
                            break;
                        default:
                            Console.WriteLine("Ошибка выбора!");
                            break;
                    }
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }

        static void SlowPrint(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(200); 
            }
            Console.WriteLine();
        }
    }
}
