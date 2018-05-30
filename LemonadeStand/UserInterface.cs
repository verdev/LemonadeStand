using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        static int inputAsNumber;
        
        public static void DisplayMessage(string message)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static int GrabIntegerInput()
        {
            Console.WriteLine("\nPlease enter a number:");
            ConsoleKeyInfo key = Console.ReadKey();
            if (int.TryParse(key.KeyChar.ToString(), out inputAsNumber) == true)
            {
                Console.WriteLine("\nYou entered a valid number: {0}\n", inputAsNumber);
                Console.ReadKey();
                return inputAsNumber;
            }
            else
            {
                Console.WriteLine("\nYou entered an invalid number!");
                Console.ReadKey();
                return GrabIntegerInput();
            }
        }
    }
}
