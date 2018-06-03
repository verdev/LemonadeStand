using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class StringFlatFile
    {
        public static void DisplaySplash()
        {
            StringBuilder splash = new StringBuilder();
            splash.AppendLine("  _        ___  ___ ___   ___   ____    ____  ___      ___ ");
            splash.AppendLine(" | |      /  _]|   |   | /   \\ |    \\  /    ||   \\    /  _]");
            splash.AppendLine(" | |     /  [_ | _   _ ||     ||  _  ||  o  ||    \\  /  [_ ");
            splash.AppendLine(" | |___ |    _]|  \\_/  ||  O  ||  |  ||     ||  D  ||    _]");
            splash.AppendLine(" |     ||   [_ |   |   ||     ||  |  ||  _  ||     ||   [_ ");
            splash.AppendLine(" |     ||     ||   |   ||     ||  |  ||  |  ||     ||     |");
            splash.AppendLine(" |_____||_____||___|___| \\___/ |__|__||__|__||_____||_____|");
            splash.AppendLine();
            splash.AppendLine();
            splash.AppendLine("            _____ ______   ____  ____   ___   ");
            splash.AppendLine("           / ___/|      | /    ||    \\ |   \\  ");
            splash.AppendLine("          (   \\_ |      ||  o  ||  _  ||    \\ ");
            splash.AppendLine("           \\__  ||_|  |_||     ||  |  ||  D  |");
            splash.AppendLine("           /  \\ |  |  |  |  _  ||  |  ||     |");
            splash.AppendLine("           \\    |  |  |  |  |  ||  |  ||     |");
            splash.AppendLine("            \\___|  |__|  |__|__||__|__||_____|");
            splash.AppendLine();
            splash.AppendLine();
            splash.AppendLine("                ____   ____  ___ ___    ___ ");
            splash.AppendLine("               /    | /    ||   |   |  /  _]");
            splash.AppendLine("              |   __||  o  || _   _ | /  [_ ");
            splash.AppendLine("              |  |  ||     ||  \\_/  ||    _]");
            splash.AppendLine("              |  |_ ||  _  ||   |   ||   [_ ");
            splash.AppendLine("              |     ||  |  ||   |   ||     |");
            splash.AppendLine("              |___,_||__|__||___|___||_____|");
            FormatOutput(splash.ToString());
        }
        public static void DisplayIntroduction()
        {
            StringBuilder intro = new StringBuilder();
            intro.AppendLine(" You have 7, 14, or 21 days to make as much money as possible,");
            intro.AppendLine(" and you’ve decided to open a lemonade stand! You’ll have complete");
            intro.AppendLine(" control over your business, including pricing, quality control,");
            intro.AppendLine(" inventory control, purchasing supplies. Buy your ingredients, set");
            intro.AppendLine(" your recipe, and start selling! The first thing you’ll have to");
            intro.AppendLine(" worry about is your recipe. At first, go with the default recipe,");
            intro.AppendLine(" but try to experiment a little bit and see if you can find a better");
            intro.AppendLine(" one. Make sure you buy enough of all your ingredients, or you won’t");
            intro.AppendLine(" be able to sell! You’ll also have to deal with the weather, which");
            intro.AppendLine(" will play a big part when customers are deciding whether or not to");
            intro.AppendLine(" buy your lemonade. Read the weather report every day! When the");
            intro.AppendLine(" temperature drops, or the weather turns bad (overcast, cloudy, rain),");
            intro.AppendLine(" don’t expect them to buy nearly as much as they would on a hot, hazy");
            intro.AppendLine(" day, so buy accordingly. Feel free to set your prices higher on those");
            intro.AppendLine(" hot, muggy days too, as you’ll make more profit, even if you sell");
            intro.AppendLine(" a bit less lemonade. The other major factor which comes into play is");
            intro.AppendLine(" your customer’s satisfaction. As you sell your lemonade, people will");
            intro.AppendLine(" decide how much they like or dislike it.  This will make your business");
            intro.AppendLine(" more or less popular. If your popularity is low, fewer people will");
            intro.AppendLine(" want to buy your lemonade, even if the weather is hot and sunny. But");
            intro.AppendLine(" if you’re popularity is high, you’ll do okay, even on a rainy day!");
            intro.AppendLine();
            intro.AppendLine();
            intro.AppendLine(" At the end of 7, 14, or 21 days you’ll see how much money you made.");
            intro.AppendLine(" Play again, and try to beat your high score!");
            FormatOutput(intro.ToString());
        }

        public static void DisplayInstructions()
        {
            StringBuilder instructions = new StringBuilder();
            instructions.AppendLine(" INSTRUCTIONS:");
            instructions.AppendLine();
            instructions.AppendLine();
            instructions.AppendLine(" Your goal is to make as much money as you can in 7, 14, or 21 days");
            instructions.AppendLine(" by selling lemonade at your lemonade stand.");
            instructions.AppendLine();
            instructions.AppendLine(" Buy cups, lemons, sugar, and ice cubes, then set your recipe based");
            instructions.AppendLine(" on the weather and conditions. Start with the basic recipe, but try");
            instructions.AppendLine(" to vary the recipe and see if you can do better. Lastly, set your");
            instructions.AppendLine(" price and sell your lemonade at the stand. Try changing up the price");
            instructions.AppendLine(" based on the weather conditions as well.");
            instructions.AppendLine();
            instructions.AppendLine(" At the end of the game, you'll see how much money you made. Write it");
            instructions.AppendLine(" down. and play again to try and beat your score!");
            FormatOutput(instructions.ToString());
        }
        public static void PromptForLengthOfGame()
        {
            StringBuilder gameLength = new StringBuilder();
            gameLength.AppendLine(" How long would you like to play, (7), (14), or(21) days ? ");
            FormatOutputForUserInput(gameLength.ToString());
        }
        public static void AlertInvalidEntry()
        {
            StringBuilder invalidEntry = new StringBuilder();
            invalidEntry.AppendLine(" You entered an invalid number! Please re-enter:");
            FormatOutputForUserInput(invalidEntry.ToString());
        }
        public static void FormatOutput(string message)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void FormatOutputForUserInput(string message)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
