﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public void DisplayIntroduction()
        {
            string intro = @"
You have 7, 14, or 21 days to make as much money as possible, and you’ve decided to open a lemonade stand!

You’ll have complete control over your business, including pricing, quality control, inventory control,

purchasing supplies. Buy your ingredients, set your recipe, and start selling! The first thing you’ll have to

worry about is your recipe. At first, go with the default recipe, but try to experiment a little bit and see

if you can find a better one. Make sure you buy enough of all your ingredients, or you won’t be able to sell!

You’ll also have to deal with the weather, which will play a big part when customers are deciding whether or

not to buy your lemonade. Read the weather report every day! When the temperature drops, or the weather turns

bad (overcast, cloudy, rain), don’t expect them to buy nearly as much as they would on a hot, hazy day, so buy

accordingly. Feel free to set your prices higher on those hot, muggy days too, as you’ll make more profit, even 

if you sell a bit less lemonade. The other major factor which comes into play is your customer’s satisfaction. 

As you sell your lemonade, people will decide how much they like or dislike it.  This will make your business 

more or less popular. If your popularity is low, fewer people will want to buy your lemonade, even if the weather 

is hot and sunny. But if you’re popularity is high, you’ll do okay, even on a rainy day!



At the end of 7, 14, or 21 days you’ll see how much money you made. Play again, and try to beat your high score!";
            UserInterface.DisplayMessage(intro);
            Console.ReadLine();
        }
    }
}
