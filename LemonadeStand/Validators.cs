using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class Validators
    {
        public static bool CheckForSevenFourteenOrTwentyOne(int userInput)
        {
            if (userInput == 7 || userInput == 14 || userInput == 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
