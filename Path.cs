/************************************

 Path class

 ***********************************/

// Notes:
    // Encapsulation hides details.
    // When accesing private variables,
    // we have to build Set() and Get()
    // methods.

    // Notes:
        // return (pathStep < _path.Length) ? _path[pathStep] : null;

namespace TreehouseDefense {

    class Path {

        // Declares private an array of
        // objects from the class MapLocation.
        private readonly MapLocation[] _path;

        // Builds property.
        public int Length {

            get {

                return _path.Length;

            }

        }

        // Builds constructor.
        // Takes one parameter,
        // an array of objects from the class
        // MapLocation class
        public Path(MapLocation[] path) {

            // Stores collection of objects
            // in the variable path.
            _path = path;

        }

        // Buils method.
        // Takes one parameter,
        // an array of objects from the class
        // path.
        // Get method().
        public MapLocation GetLocationAt(int pathStep) {

            // Returns the path in the array.
            // Builds if statement.
            if (pathStep < _path.Length) {

                return _path[pathStep];

            } else {

                return null;
            }

        }

        // Builds method.
        // Takes one parameter,
        // an object from the class MapLocation.
        // Returns true if the MapLocation is
        // on the path.
        public bool IsOnPath(MapLocation location) {

            // Builds for loop.
            // Iterates through of the locations
            // in the path array.
            foreach(var pathLocation in _path) {

                // Builds if statement.
                // Method call
                // using object name.
                if(location.Equals(pathLocation)) {

                    return true;

                }

            }

            // Returns false if
                // it didn't find the location in
                // the array.
                return false;

        }

    }

}
