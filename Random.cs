/*********************************

Ramdom static class

**********************************/

// In static classes,
// methods have to be implemented as static.

namespace TreehouseDefense {

  static class Random {

    // Builds object from the System.Ramdom class.
    private static System.Random _random = new System.Random();

    // Builds method.
    // Takes no parameters.
    public static double NextDouble() {

      // Returns random integer.
      return _random.NextDouble();

    }

  }

}
