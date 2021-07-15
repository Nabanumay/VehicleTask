using Car;
using Motorbike;
using System;

namespace VehicleTask
{
    class Program
    {

        public static bool Validation(string input, int range, int level)
        {
            int choice;
            
                try
                {
                    choice = int.Parse(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Entry, please enter an integer.");
                    return false;
                }


            for(int i = 1; i <= range; i++)
            {
                if(choice == i)
                    return true;
                
            }
            if (level == 1)
                Console.WriteLine("Invalid entry, Enter 1 for car, 2 for motorcycle");

            else if (level == 2 && range == 3)
                Console.WriteLine("Invalid entry, enter 1 for sedan, 2 for SUV, 3 for truck");

            else
                Console.WriteLine("Invalid entry, enter 1 for motorcycle, 2 for tricycle");

            return false;

        }
        public static void WriteInfo(Vehicle.Vehicle vehicle)
        {
            Console.WriteLine(vehicle.ToString());
            Console.WriteLine(vehicle.tire.ToString());

        }
        
        
        static void Main(string[] args)
        {
            Tire tire = new Tire("Pirelli", 22.5, 3.2, 45.3); 
            Console.WriteLine("Choose your vehicle: \n Press 1 for car, 2 for motorcycle");
            string input = Console.ReadLine();
            string color;
            int vehicleChoice, carChoice, bikeChoice;
             while (!Validation(input, 2, 1))
            { 
                input = Console.ReadLine();
             }

            vehicleChoice = int.Parse(input);
            switch (vehicleChoice)
            {
                case (int)VehicleType.Car:
                    Console.WriteLine("Choose your car: \nPress 1 for Sedan, 2 for SUV, 3 for Truck");
                    input = Console.ReadLine();
                    while (!Validation(input, 3, 2))
                    {
                        input = Console.ReadLine();
                    }
                    carChoice = int.Parse(input);
                    switch (carChoice)
                    {
                        case (int)CarType.Sedan:
                            Console.WriteLine("Please choose a color");
                            color = Console.ReadLine();
                            Sedan sedan = new Sedan(color, 4, 323, 520, 255, 2000, 150, 300, 100, tire);
                            WriteInfo(sedan);
                            while (sedan.Actions())
                            {

                            }
                            
                            break;


                        case (int)CarType.SUV:
                            Console.WriteLine("Please choose a color");
                            color = Console.ReadLine();
                            SUV suv = new SUV(color, 4, 323, 520, 255, 2000, 150, 300, 100, tire);
                            WriteInfo(suv);
                            break;

                        case (int)CarType.Truck:
                            Console.WriteLine("Please choose a color");
                            color = Console.ReadLine();
                            Truck truck = new Truck(color, 6, 323, 520, 255, 2000, 150, 300, 100, tire);
                            WriteInfo(truck);
                            break;
                    }
                    break;

                case (int)VehicleType.Motorcycle:
                    Console.WriteLine("Choose your Motorcycle: \nPress 1 for Motorcycle, 2 for Tricycle");
                    input = Console.ReadLine();
                    while (!Validation(input, 2, 2))
                    {
                        input = Console.ReadLine();
                    }
                    bikeChoice = int.Parse(input);
                    switch (bikeChoice)
                    {
                        case (int)MotorcycleType.Motorcycle:
                            Console.WriteLine("Please choose a color");
                            color = Console.ReadLine();
                            Motorcycle motorcycle = new Motorcycle(color, 2, 323, 520, 255, 2000, 150, 300, 100, tire);
                            WriteInfo(motorcycle);
                            break;

                        case (int)MotorcycleType.Tricycle:
                            Console.WriteLine("Please choose a color");
                            color = Console.ReadLine();
                            Tricycle tricycle = new Tricycle(color, 3, 323, 520, 255, 2000, 150, 300, 100, tire);
                            WriteInfo(tricycle);
                            break;

                    }
                    break;

            }
        }
    }
}
