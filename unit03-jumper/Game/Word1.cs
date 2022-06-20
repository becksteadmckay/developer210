using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    /// <summary>
    /// <para>The person hiding from the Seeker.</para>
    /// <para>
    /// The responsibility of Word is to keep track of its location and distance from the seeker.
    /// </para>
    /// </summary>
    public class Word
    {
        
        public bool _true;

        private TerminalService terminalservice = new TerminalService();
        private List<char> _guesses = new List<char>();

        private List<string> _wordList = new List<string>();

        public string _word;
        public Word()
        {

            makeWordList();
            chooseRandomWord();
            
            
        }


        private void makeWordList()
        {
            foreach (string line in System.IO.File.ReadLines(@"Game\words.txt"))
            {  
                if (line.Length > 10){

                _wordList.Add(line);  
                }
            }
            
        }

        private void chooseRandomWord()
        {
            Random random = new Random();
            int number = random.Next(_wordList.Count + 1);
            
            _word = _wordList[number];
        }

        /// <summary>
        /// Constructs a new instance of Word. 
        /// </summary>

        /// <summary>
        /// Gets a hint for the seeker.
        /// </summary>
        /// <returns>A new hint.</returns>
        public string GetHint()
        {
            string hint = "";
            foreach (var letter in _word)
            {
                if (_guesses.Contains(letter))
                {
                    hint += $"{letter}";
                }
                else
                {
                    hint += "_";
                }

            }
            return hint;
        }

        public string checkWord(Word Word)
        {
            if (Word.GetHint() == Word._word)
            {
                return "Found Word!";
            }
            else
            {
                return "Try Again";
            }
        }

        public void checkGuess(char guess)
        {
            if (_word.Contains(guess))
            {
                _true = true;
            }
            else
            {
                _true = false;
            }
        }

        /// <summary>
        /// Watches the seeker by keeping track of how far away it is.
        /// </summary>
        /// <param name="seeker">The seeker to watch.</param>
        public void WatchGuesses(Guess guess)
        {
            _guesses.Add(guess.GetGuess());
        }

        public string getWord()
        {
            return $"The word was {_word}";
        }

        public void returnGuessList()
        {
           
            terminalservice.WriteText("");
            terminalservice.WriteText("");
            for (int i = 0; i < _guesses.Count; i ++)
            {
                Console.Write($"{_guesses[i]}, ");
            }
            terminalservice.WriteText("");
            terminalservice.WriteText("");

        }
    }
}