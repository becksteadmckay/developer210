using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        bool isPlaying = true;
        int score = 0;
        int totalScore = 100;
        
        int previousCard = 7;



        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {

            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
                
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Still Playing [y/n] ");
            string rollDice = Console.ReadLine();
            isPlaying = (rollDice == "y");
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }
            Card card = new Card();

            Console.WriteLine($"next: {card.value} | previous: {previousCard}");

            previousCard = card.value;
            int nextCard = card.value;

            Console.WriteLine($"Above or Below {previousCard} ('a','b')");
            string guess = Console.ReadLine();

            if ( nextCard > previousCard && guess == "a")
            {
                score = 100;
            }
            else if (nextCard < previousCard && guess == "b")
            {
                score = 100;
            }
            else
            {
                score = -100;
            }

            totalScore = score + totalScore;

        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>

        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            Console.WriteLine($"{totalScore}");

        }
    }
}


// Console.WriteLine($"Do you think the next card is above or below {card1.value}? ('a' or 'b')");
//             string above_below = Console.ReadLine();

//             if (above_below == "a")
//             {
//                 if(card1.value > card2.value)
//                 {
//                     score = -100;
//                 }
//                 else if(card1.value < card2.value)
//                 {
//                     score = 100;
//                 }
//                 else
//                 {
//                     score = 0;
//                 }
//             }
//             if (above_below == "b")
//             {

//                 if(card1.value < card2.value)
//                 {
//                     score = -100;
//                 }
//                 else if(card1.value > card2.value)
//                 {
//                     score = 100;
//                 }
//                 else
//                 {
//                     score = 0;
//                 }
//             }
//             totalScore += score;

//             Console.WriteLine($"({card1.value},{card2.value})");

//             Console.WriteLine($"{totalScore}");
            