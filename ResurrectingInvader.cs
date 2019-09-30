/**********************************

ResurrectingInvader class

**********************************/

// Methods, variables, and properties
// in an interface have to be implemented.

// We want to minimize the
// amount of code that
// our code is depending on.

// Interfaces allows us to be dependent on the interface
// instead of the concrete implementation of classes.
// That is the beauty of abstraction.

namespace TreehouseDefense {

  // Builds class,
  // inherits from the IInvader interface
  // in order to have access to variables, methods,
  // and properties.
  class ResurrectingInvader : IInvader {

    // Builds private variable from the BasicInvader class.
    public BasicInvader _incarnation1;
    // Builds private variable from the StrongInvader class.
    public StrongInvader _incarnation2;
    // Builds property.
    // Second way of building a property.
    // Auto property.
    public MapLocation Location => _incarnation1.IsNeutralized ? _incarnation2.Location : _incarnation1.Location;

    // Builds constructor.
    // Takes one parameter,
    // an object from the class Path.
    // Constructor is called as soon
    // as an object(instance) of the
    // class is declared.
    public ResurrectingInvader(Path path) {

      // Builds object from the BasicInvader class.
      // Constructor takes one parameter.
      // Stores output in the variable _incarnation1.
      _incarnation1 = new BasicInvader(path);
      // Builds object from the StrongInvader class.
      // Constructor takes one parameter.
      // Stores output in the variable _incarnation2.
      _incarnation2 = new StrongInvader(path);

    }

    // Builds computed property.
    // True if the invader has reached the end of the path.
    public bool HasScored  => _incarnation1.HasScored || _incarnation2.HasScored;

    // Builds abstract property.
    public int Health => _incarnation1.IsNeutralized ? _incarnation2.Health : _incarnation1.Health;

    // Builds computed property.
    // Checks to see if the invader is neutralized.
    public bool IsNeutralized => _incarnation1.IsNeutralized && _incarnation2.IsNeutralized;

    // Builds computed property.
    public bool IsActive => !(IsNeutralized || HasScored);

    // Builds method.
    // Takes no parameters.
    // Advances invader down the path.
    public void Move() {

      // Method call
      // using object name.
      // Takes no parameters.
      _incarnation1.Move();
      // Method call
      // using object name.
      // Takes no parameters.
      _incarnation2.Move();

    }

    // Builds virtual method.
    // Takes one parameter.
    public void DecreaseHealth(int factor) {

      // Builds if statement.
      if(!_incarnation1.IsNeutralized) {

        // Method call
        // using object name.
        // Takes one parameter.
        _incarnation1.DecreaseHealth(factor);

      } else {

        // Method call
        // using object name.
        // Takes one parameter.
        _incarnation2.DecreaseHealth(factor);

      }

    }

  }

}
