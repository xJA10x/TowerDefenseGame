/**********************************
 
 Map class
 
 **********************************/

// Notes:
    // Fields is another name for variables.
    // Private fields(variables), are only
    // accesible in the class they are declared in.
    // Public fields can be access by any method,
    // in any class.
    // In order to access private variables we have
    // to build Set() and Get() methods.
    // A constructor is called as soon as an
    // object from the class is declared.

namespace TreehouseDefense {
    
    class Map {
        
        // Declares variable.
        public readonly int Width;
        // Declares variable.
        public readonly int Height;
       
        // Builds Constructor.
        // Takes two paramters,
        // globar variables width and height.
        // Constructor is called as soon
        // as an object from the class is declare.
        public Map(int width, int height) {
            
            // Stores input in the variable width.
            Width = width;
            // Stores input in the variable height.
            Height = height;
           
        }
        
        // Builds method.
        // Takes one parameter,
        // an abject from the class Point.
        // Determines if point is on the map.
        public bool OnMap(Point point) {
           
           bool inBounds = point.X >= 0 && point.X < Width &&
                           point.Y >= 0 && point.Y < Height;
           
            // Returns true if point is on the map,
            // otherwise returns false.
            return inBounds;
           
        }
       
    }
    
    
    
}
