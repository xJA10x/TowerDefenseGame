/************************************

MapLocation class

**************************************/

// Notes:
	// Base class is the parent class or 
	// the super class.
	// Sub class is the child class or the 
	// Derived class
	// The keyword this refers to the current object.



namespace TreehouseDefense {

	// Builds class,
	// inherits from the Point class.
	 class MapLocation : Point {

		// Builds constructor.
		// Constructor takes three parameters.
		// Variables x and y and an 
		// object from the class Map.
		// Calls the Point class constructor.
		// Constructor is called as soon
		// as an object of the class is declared.
		public MapLocation(int x, int y, Map map) : base(x, y) {

			// Builds if statement.
			// Method call,
			// takes one parameter.
			if (!map.OnMap(this)) {

				// Throws exception.
				throw new OutOfBoundsException(this +  " is outside the boundaries of the mapw");



			}


		}
        
        // Builds method.
        // Takes two parameters,
        // an object from the class MapLocation and variable range.
        public bool InRangeOf(MapLocation location, int range) {
            
            // Method call.
            // Takes one parameter,
            // object from the class MapLocation.
            return DistanceTo(location) <= range;
            
            
        }

	}

}
