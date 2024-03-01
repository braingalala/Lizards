using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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
            Console.WriteLine("1. Отправиться в путешествие\n 2. Магазин\n3. Инвентарь\n 4. Пойти отдыхать");
            try
            {
                while (true)
                {
                    char choice = Console.ReadKey().KeyChar;
                    switch (choice)
                    {
                        case '1':
                            break;
                        case '2':
                            break;
                        case '3':
                            break;
                        case '4':
                            break;
                        default:
                            Console.WriteLine("Ошибка выбора!");
                            break;
                    }
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
