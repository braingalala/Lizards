using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizards
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInteraction ui = new UserInteraction();
            ui.Greetings();
            ui.StartByUserChoice();
            
            Console.ReadKey();
        }
    }
}
