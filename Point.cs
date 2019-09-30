/*********************************

 Point class

***********************************/

// Notes:
    // Cartisian distance formula.
    // A hascode as unique identifier for an object.
    // Every object created has a unique identifier.
    // This id is actually its memory address.
    // We can only return a single integer as a hascode.

using System;

namespace TreehouseDefense {

    class Point {

        // Declares global variables.
        public readonly int X;
        public readonly int Y;

        // Builds constructor.
        // Takes two parameters,
        // global variables X and Y.
        public Point(int x, int y) {

            // Stores input in the variable X.
            X = x;
            // Stores input in the variable Y.
            Y = y;

        }

        // Overrides ToString() method.
        public override string ToString() {

            return X + "," + Y;

        }

        // Overrides method.
        // Returns true if the two coordinates of the point are
        // equal.
        // Takes one parameter,
        // an object from the System class
        public override bool Equals(object obj) {

          // Builds if statement.

          if(!(obj is Point)) {

              return false;

          }

          // Cast point to an object.
          Point that = obj as Point;

          // Returns true if the two objects are the same.
          return this.X == that.X && this.Y == that.Y;

        }

        // Method override.
        // Takes no parameters.
        public override int GetHashCode() {

          // Creates hashCode.
          // Returns a hashCode.
          return X.GetHashCode() * 31 + Y.GetHashCode();

        }

        // Builds method.
        // Takes two parameters,
        // global variables X and Y.
        public int DistanceTo(int x, int y) {

            // Initializes variable.
            // Stores distance between X2-X1
            int xDiff = X - x;
            // Initializes variable.
            // Stores distance between Y2-Y1.
            int yDiff = Y - y;

            // Initializes variable.
            // Stores square root of xDiff.
            int xDiffSquared = xDiff * xDiff;
            // Initializes variable.
            // Stores square root of yDiff.
            int yDiffSquared = yDiff * yDiff;

            // Method call.
            // Returns result from cartisian formula.
            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);

        }

        // Builds method.
        // Takes two parameters,
        // two objects from the class point.
        // Method overload.
        public int DistanceTo(Point point) {

            // Method call.
            // Takes two parameters.
            return DistanceTo(point.X, point.Y);

        }

    }

}
