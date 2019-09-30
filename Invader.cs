/*************************************

 Invader class

 ***********************************/

// Notes: Classes contains fields, Properties,
// Methods, and constructors which are all
// members of the class.

// Variables path, pathStep, location property, and move method
// are all members of the Invader class.

// In order to override methods in C#,
// we have to declare them virtual and
// then override the method in the class with are working with.

using System;

namespace TreehouseDefense {

    // Builds abstract base class.
    // Implements IInvader interface
    abstract class Invader : IInvader {

        // Builds object from the class
        // MapLocation.
        //private MapLocation _location;

        // Builds method.
        // Takes one parameter,
        // an object from the class MapLocation.
        // Set() method.
        //public void SetLocation(MapLocation value) {

            // Stores valaue in the variable
            // _location.
          //  _location = value;

        //}

        // Builds method.
        // Takes no parameters,
        // Get() method.
        //public MapLocation GetLocation() {

            // Retursn location.
          //  return _location;

        //}

        // Builds property.
        // First way of building a property.
        //  public MapLocation Location {

            // set setter
            // to store private variable.
            //  set {

                // Stores value
                // in the variable _location.
                //  _location = value;

            //}

            // get setter
            // to access private variable.
            //get {

                // Returns location.
               // return _location;

            //}

        //}

        // Declares private variable.
        private readonly Path _path;
        // Initializes private variable
        // to keep track of the path walked in.
        // All invader will start at step 0.
        private int _pathStep = 0;
        // Initializes variable to keep
        // track of how much health the invader has
        // remaining.

        // Builds virtual property.
        // Read only property.
        protected virtual int StepSize { get; } = 1;

        // Builds property.
        // Second way of building a property.
        // Auto property.
        public MapLocation Location {

            get {

                // Retursn the location
                // the the invader is at
                // give the pathStep.
                return _path.GetLocationAt(_pathStep);
            }

        }

        // Builds abstract property.
        public abstract int Health {

            get;
            protected set;

        }

        // Builds computed property.
        // True if the invader has reached the end of the path.
        public bool HasScored {

            get {

                // Returns true if the path step is > the path lenght.
                return _pathStep >= _path.Length;

            }

        }

        // Builds computed property.
        // Checks to see if the invader is neutralized.
        public bool IsNeutralized {

            get {

                return Health <= 0;
            }

        }

        // Builds computed property.
        public bool IsActive {

            get {

                return !(IsNeutralized || HasScored);

            }

        }

        // Builds constructor.
        // Takes one parameter,
        // an object from the class Path.
        // Constructor is called as soon
        // as an object from the class is declared.
        public Invader(Path path) {

            // Stores path in the variable
            // _path.
            _path = path;

        }

        // Builds method.
        // Takes no parameters.
        // Advances invader down the path.
        // Every time the method
        // is called, it will advance the invader by 1.
        public void Move() {

            // Advances invader by 1
            // every time the method is called..
            _pathStep += StepSize;

        }

        // Builds virtual method.
        // Takes one parameter.
        public virtual void DecreaseHealth(int factor) {

            // Keepts track of health
            // every time the method is call.
            // Stores output in the variable Health.
            Health -= factor;
            Console.WriteLine("Shot at an hit an invader!");

        }

    }

}
