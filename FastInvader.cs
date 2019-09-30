/*****************************************

 FastInvader class

 *****************************************/

namespace TreehouseDefense {

    // Builds class.
    // Inherits from the class Invader
    class FastInvader : Invader {


        // Method overriding.
        // Read only property.
        protected override int StepSize { get; } = 2;

        // Overrides property.
        public override int Health {

            get;
            protected set;

        } = 2;

        // Builds constructor.
        // Takes one parameter,
        // an object from the class Path.
        // Passes the parameters to
        // the constructor from the Invader class too.
        public FastInvader(Path path) : base(path) {

        }






    }

}
