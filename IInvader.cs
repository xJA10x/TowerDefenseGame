/********************************

IInvader class

*********************************/

// Interface defines what
// public methods a class should have.
// Interfaces exposed what is actually needed
// by the code that is using the class.

namespace TreehouseDefense {

  // Builds interface.
  interface IMappable {

    // Builds property.
    // Second way of building a property.
    // Auto property.
    MapLocation Location { get; }

  }

  // Builds interface.
  interface IMovable  {

    // Builds method.
    // Takes no parameters.
    // Advances invader down the path.
    void Move();

  }

  // Builds interface.
  // Inherits from the IMappable interface and
  // the IMovable.
  interface IInvader : IMappable, IMovable {

    // Builds abstract property.
    int Health { get; }

    // Builds computed property.
    // True if the invader has reached the end of the path.
    bool HasScored { get; }

    // Builds computed property.
    // Checks to see if the invader is neutralized.
    bool IsNeutralized { get; }

    // Builds computed property.
    bool IsActive { get; }

    // Builds virtual method.
    // Takes one parameter.
    void DecreaseHealth(int factor);

  }

}
