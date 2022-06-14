using System;
using System.Collections.Generic;
using Unit03.Game;


namespace Unit03.Game
{
        public class Guess
    {
        private char guess;
        public Guess(){}

        public char GetGuess()
        {
            return guess;
        }
        public char MoveLocation(char newGuess)
        {
            guess = newGuess;
            return guess;
        }

    }
}