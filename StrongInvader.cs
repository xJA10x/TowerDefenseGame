/*********************************
 
 StrongInvader class
 
 *********************************/

namespace TreehouseDefense {
    
    // Builds class.
    // Inherits from the Invader class
    // in order to have access to methods and variables.
    class StrongInvader : Invader {
       
       // Builds method.
       // Method override.
       public override int Health {get; protected set;} = 2;
       
       
        // Builds constructor.
        // Takes one parameter,
        // an object from the class Path.
        // Pases the parameter to the constructor of the
        // Invader class too.
        public StrongInvader(Path path) : base(path) {
            
            
            
            
        }
        
    }
    
}
