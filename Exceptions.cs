/**********************************

Exceptions class

**********************************/

namespace TreehouseDefense {

	// Builds class.
	// Inherits from the System.Exception class
	class TreehouseDefenseException : System.Exception {

		// Builds constructors.
		// Takes no parameters.
		public TreehouseDefenseException() {


			
		}

		// Builds constructor.
		// Takes one parameter,
		// a string.
		// Constructor is called as soon as 
		// an object from the class is declared.
		public TreehouseDefenseException(string message) : base(message) {




		}

	}

	// Builds class.
	// Inherits from the TreehouseDefenseException
	class OutOfBoundsException : TreehouseDefenseException {

		// Builds constructror.
		// Contructor takes no parameters.
		public OutOfBoundsException() {



		}

		// Builds constructors.
		// Takes one parameter,
		// a string.
		public OutOfBoundsException(string message) : base(message) {

		}



	}

}