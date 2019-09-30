/************************************

BasicInvader abstract class

*************************************/

namespace TreehouseDefense {

  // Builds class.
  // Inhertis from the Invader class
  class BasicInvader : Invader {

    // Overrides property.
    public override int Health {

        get;
        protected set;

    } = 2;

    // Builds constructor.
    // Takes one parameter,
    // an object from the class Path.
    // Pases parameter to the base constructor.
    public BasicInvader(Path path) : base(path) {


    }

  }

}
