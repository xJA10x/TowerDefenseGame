/******************************

 Tower class

********************************/

// We declared protected properties, variables, and methods
// so that they can be overriden in other
// classes.

using System;

namespace TreehouseDefense {

    class Tower {

        // Initializes virtual Property.
        protected virtual int Range { get; } = 1;
        // Initializes virtual Property.
        protected virtual int Power { get; } = 1;
        // Initializes virtaul Property.
        protected virtual double Accuracy { get; } = 0.75;

        // Declares private variable from the class MapLocation.
        private readonly MapLocation _location;

        // Builds constructor.
        // Takes one parameter,
        // an object from the class MapLocation.
        // Constructor is called as soon as an
        // object from the class is declared.
        public Tower(MapLocation  location) {

            // Stores input in the variable _location.
            _location = location;

        }

        // Builds method.
        // Takes no parameters.
        public bool IsSuccessfulShot() {

            // Returns random number.
            // Returns true if the number generate is < 0.75;
            return Random.NextDouble() < Accuracy;

        }

        // Builds method.
        // Takes one parameter,
        // an array from the class Invader.
        public void FireOnInvadors(IInvader[] invaders) {

            // Builds foreach loop.
            // Loops through every element in the array.
            foreach(IInvader invader in invaders) {

                // Builds if statement.
                // Checks to see if location is in range to the tower.
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range)) {

                    // Method call.
                    // Builds if statement.
                    if(IsSuccessfulShot()) {

                        // Method call
                        // using object name.
                        // Takes one parameter.
                        invader.DecreaseHealth(Power);
                        // Outputs to the console.


                        // Builds if statement.
                        // Method call
                        // using object name.
                        if(invader.IsNeutralized) {

                            // Outputs to the console.
                            Console.WriteLine("Neutralized an invader" + invader.Location + "!");

                        }

                    } else {

                        Console.WriteLine("Shot at and missed an invader.");

                    }

                    // If the invader is in range,
                    // it will decrease its health.
                    invader.DecreaseHealth(Power);
                    // Exits the loop.
                    break;

                }

            }

        }

    }

}
