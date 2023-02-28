using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONECreate an abstract class called Vehicle
             * DONEThe vehicle class shall have three string properties Year, Make, and Model
             * DONESet the defaults to something generic in the Vehicle class
             * DONEVehicle shall have an abstract method called DriveAbstract with no implementation
             * DONEVehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONENow create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONEAdd a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONEProvide the implementations for the abstract methods
             * DONEOnly in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var car1 = new Car()
            {
                HasTrunk = true,
                Year = "2004",
                Make = "Toyota",
                Model = "Corolla"
            };
            var motorcycle1 = new Motorcycle() 
            { 
                HasSideCart = true,
                Year = "2006",
                Make = "Suzuki",
                Model = "Ninja"
            }; 
            Vehicle vehicle1 = new Car() 
            { 
                HasTrunk = true,
                Year = "2010",
                Make = "Mazda",
                Model = "3",
            };
            Vehicle vehicle2 = new Motorcycle()
            {
                HasSideCart = false,
                Year = "2009",
                Make = "Honda",
                Model = "CRF250"
            };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(vehicle1);
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year:{vehicle.Year}");
                Console.WriteLine($"Make:{vehicle.Make}");
                Console.WriteLine($"Model:{vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle
            
            #endregion            
            
        }
    }
}
