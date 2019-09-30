/*************************************
 
 LongRageTower class
 
 **************************************/

namespace TreehouseDefense {
    
    // Builds class.
    // Inherits from the LongRangeTower
    // in order to have access to methods and
    // variables.
    class LongRangeTower : Tower {
        
        // Initializes virtual Property.
        protected override int Range { get; } = 3;
        // Initializes virtual Property.
        protected override int Power { get; } = 3;
        // Initializes virtaul Property.
        protected override double Accuracy { get; } = 0.90;
        
        // Builds constructor.
        // Takes one parameter,
        // an object from the class MapLocation.
        // Pases the object to the Tower constructor too.
        public LongRangeTower(MapLocation location) :  base(location) {
            
        }
        
        
    }
    
}
