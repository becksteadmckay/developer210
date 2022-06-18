namespace Unit04.Game.Casting
{
    class Artifact: Actor
    {
        public string _message;

        private int _score = 1;
        public Artifact()
        {

        }
        public string GetMessage()
        {
            return _message;
        }
        public void SetMessage(string message)
        {
            _message = message;
        }
        public int GetScore()
        {
            return _score;
        }
        public void _add()
        {
            _score += 1;
            
        }
        public void _subtract()
        {
            _score += -1;
        }
        // public void SetMessage(string message)
        // {
        //     _message = message;
        // }

    }
    // TODO: Implement the Artifact class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Actor class.

        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>


    // 2) Create the class constructor. Use the following method comment.
        
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
       

    // 3) Create the GetMessage() method. Use the following method comment.
        
        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        

    // 4) Create the SetMessage(string message) method. Use the following method comment.
        
        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
    
}