

using System;


namespace Unit02.Game
{
    public class Card
    {
        public int value;
        public int points;


        public Card()
        {
            Random random = new Random();
            value = random.Next(1, 14);
            
        }

        public bool greater(int ph)
        {
            if (value > ph)
            {
                return true;
            }

            return false;
        
        }
        public bool less(int ph)
        {
            if (value > ph)
            {
                return true;
            }

            return false;
        
        }

    }
}


