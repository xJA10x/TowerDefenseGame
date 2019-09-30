/*******************************
 
 PowerfulTower class
 
 *******************************/

namespace TreehouseDefense {
    
    // Builds class.
    // Inherits from the tower class
    // in order to have access to methods
    // and variables.
    class PowerfulTower : Tower {
       
        // Initializes virtual Property.
        protected override int Range { get; } = 2;
        // Initializes virtual Property.
        protected override int Power { get; } = 2;
        // Initializes virtaul Property.
        protected override double Accuracy { get; } = 0.80;
        
        // Builds constructor.
        // Takes one parameter,
        // an object from the class MapLocation.
        // Pases the object to the Tower constructor too.
        public PowerfulTower(MapLocation location) :  base(location) {
           
        }
        
    }
    
}
