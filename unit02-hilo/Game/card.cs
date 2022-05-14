

using System;


namespace Unit02.Game
{
    public class Card
    {
        public int value = -1;
        public Card()
        {
        }

        /// Generates a new random value and calculates the points for the die.
        /// </summary>
        public void Draw()
        {
            Random random = new Random();
            value = random.Next(1, 14);
            
        }

    }
}


