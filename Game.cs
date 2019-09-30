/*********************************

 Game class

***********************************/

// Notes:
    // Encapsulation hides implementation details.

using System;

namespace TreehouseDefense {

    class Game {

        public static void Main(String[] args) {

          // Outputs empty line.
          Console.WriteLine("");
          // Outputs to the console.
          Console.WriteLine("############# Running Program ##################");
          // Outputs empty line.
          Console.WriteLine("");

            // Builds object from the class Map.
            // Constructor takes two parameters.
            Map map = new Map(8, 5);

            // Builds object from the MapLocation
            // class. Constuctor takes three parameters.
            // variables x and y and an object from the class
            // map.
            // Builds try and catch exception
            try {

                // Builds object from the class Path.
                // Constructor takes one parameter,
                // an array of objects from the class MapLocation.
                Path path = new Path(

                    new [] {

                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)

                    }

                );


                // Builds object from the class MapLocation.
                // Contructor takes three parameters.
                MapLocation location = new MapLocation(0, 2, map);

                // Builds an array of object from the interface IInvaders.
                // This code below is an example of polymorphism.
                IInvader[] invaders = {

                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path),
                    new ResurrectingInvader(path)

                };

                // Builds an array of objects from the class Tower.
                Tower[] towers = {

                  // Builds object.
                  // Takes three parameters.
                  new Tower(new MapLocation(1, 3, map)),
                  new PowerfulTower(new MapLocation(3, 3, map)),
                  new SniperTower(new MapLocation(5, 3, map)),
                  new LongRangeTower(new MapLocation(2, 4, map))

                };

                // Builds object from the class Level.
                // Takes one parameter,
                // the array of objects from the class level.
                Level level = new Level(invaders) {

                    Towers = towers

                };

               // Initializes variable.
               // Stores method call.
               // Takes no parameters.
               bool playerWon = level.Play();

               // Outputs to the console.
               Console.WriteLine("Player " + (playerWon ? "won" : "lost"));

            } catch(OutOfBoundsException ex) {

                // Outputs to the console
                // if exception is thrown.
                Console.WriteLine(ex.Message);

            } catch(TreehouseDefenseException) {

                // Outputs to the console.
                Console.WriteLine("unhandled TreehouseDefenseException");


            } catch(Exception ex) {

                // Outputs to the console.
                Console.WriteLine("Unhandled Exception: " + ex);

            }


            // Outputs empty line.
            Console.WriteLine("");
            // Outputs to the console.
            Console.WriteLine("###################### Exiting Program #####################");
            // Outputs empty line.
            Console.WriteLine("");

        }

    }

}
