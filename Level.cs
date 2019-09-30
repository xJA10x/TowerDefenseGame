/************************************

 Level class

 *************************************/

namespace TreehouseDefense {

     class Level {

        // Initializes array from the class Invader.
        private readonly IInvader[] _invaders;

        // Builds property from the class Tower.
        public Tower[] Towers {

            get;
            set;

        }

        // Builds constructor.
        // Takes one parameter,
        // an arrray from the class invaders.
        // Cosntructor is called as soon
        // as object from the class is declared.
        public Level(IInvader[] invaders) {

            // Stores input in the variable _invaders.
            _invaders = invaders;

        }

        // Builds method.
        // Returns true if the player wins,
        // false otherwise.
        public bool Play() {

            // Initializes loop control variable.
            int remainingInvaders = _invaders.Length;

            // Builds while loop.
            // Run until all invaders are neutralized or an
            // invader reaches the end of a path.
            while(remainingInvaders > 0) {

                // Builds foreach loop.
                // Each tower has opportunity to fire on invaders.
                foreach(Tower tower in Towers) {

                    // Method call
                    // using object name.
                    // Takes one parameter,
                    // array _invaders.
                    tower.FireOnInvadors(_invaders);

                }

                remainingInvaders = 0;

                // Builds foreach loop.
                // Count and move the invaders that are still active.
                foreach(IInvader invader in _invaders) {

                    // Builds if statement.
                    if(invader.IsActive) {

                        // Method call
                        // using object name.
                        // Takes no parameters.
                        invader.Move();

                        // Builds if statement.
                        // Checks to see if the invader
                        // has reached the end of the path.
                        if(invader.HasScored) {

                            return false;

                        }

                        // Increments loop control variable.
                        remainingInvaders++;

                    }

                }

            }

            return true;

        }

    }

}
