using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private bool isPlaying = true;
        private Word word = new Word();
        private Guess guess = new Guess();

        private Chute chute = new Chute();
        private TerminalService terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
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
        /// Moves the seeker to a new location.
        /// </summary>
        private void GetInputs()
        {
            
            char userInput = terminalService.ReadChar("\nEnter any letter: ");
            guess.MoveLocation(userInput);
            word.checkGuess(userInput);
        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            word.WatchGuesses(guess);
            chute.WatchWord_true(word);
            word.checkWord(word);
            

        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            word.returnGuessList();
            terminalService.WriteText(chute.GetChute());
            string hint = word.GetHint();
            terminalService.WriteText(hint);
            if (chute.returnCount() > 6 || word._word == word.GetHint())
            {
                isPlaying = false;
                terminalService.WriteText(word.getWord());
                terminalService.WriteText(word.checkWord(word));
            }
            
        }
    }
}