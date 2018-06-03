using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInput
    {
        public static string userInput;
        public static int integer;
        public static void GrabSingleDigitInteger()
        {
        }
        public static int GrabMultiDigitInteger()
        {
            userInput = Console.ReadLine();
            int.TryParse(userInput, out integer);
            return integer;
        }
    }
}
