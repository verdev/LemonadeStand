using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public int userInput;
        public void RunGame()
        {
            GameStartupMessages();
            userInput = GrabLengthOfGameInput();
        }
        public void GameStartupMessages()
        {
            StringFlatFile.DisplaySplash();
            StringFlatFile.DisplayIntroduction();
            StringFlatFile.DisplayInstructions();
            StringFlatFile.PromptForLengthOfGame();
        }

        public int GrabLengthOfGameInput()
        {
            userInput = UserInput.GrabMultiDigitInteger();
            if (!Validators.CheckForSevenFourteenOrTwentyOne(userInput))
            {
                StringFlatFile.AlertInvalidEntry();
                return GrabLengthOfGameInput();
            }
            else
            {
                return userInput;
            }

        }
    }
}
