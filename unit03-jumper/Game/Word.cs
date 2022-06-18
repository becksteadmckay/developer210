using System;
using System.Collections.Generic;


namespace WordNameSpace
{

    public class Word
    {
       
        private string word;

        private List<char> _guess = new List<char>();

        public Word()
        {
            word = "apple";

        }

        public void getGuess()
        {
            Console.Write("Guess a letter.");
            char guess = Console.ReadLine()[0];
            _guess.Add(guess);
        }

        public char returnGuess()
        {
            return guess;
        }

        public void getHint()
        {
            string hint = "";

            foreach (char letter in word)
            {
                if (_guess.Contains(letter)){
                    hint+= $"{letter}";
                }
                else
                {
                    hint +=  "_";
                
                }
            }
            Console.WriteLine(hint);
        }
        public bool checkGuess(char guess)
        {
                if (_guess.Contains(guess)){
                    return true;
                }
                return false;
        }
        
        
    }
}