/*********************************

 ShieldedInvader class

 *********************************/

using System;

namespace TreehouseDefense {

    // Builds class.
    // Inherits from the Invader class.
    class ShieldedInvader : Invader {

        // Overrides property.
        public override int Health {

            get;
            protected set;

        } = 2;

        // Builds constructor.
        // Takes one parameter,
        // an object from the class Path.
        // Pases the path to the Invader class constructor.
        public ShieldedInvader(Path path) : base(path) {

        }

        // Builds method.
        // Overrides the virtual method of the invader class.
        // Takes one parameter.
        public override void DecreaseHealth(int factor) {

            // Builds if statement.
            if(Random.NextDouble() < 0.5) {

                // Method call.
                // Calls the DecreaseHealth
                // method from the Invade class
                // using the base keyword.
                base.DecreaseHealth(factor);

            } else {

                // Outputs if it blocks the shot.
                Console.WriteLine("Shot at a shilded invader but it sustained no damage.");

            }

        }

    }

}
