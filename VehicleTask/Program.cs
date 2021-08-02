using Car;
using Motorbike;
using System;
using System.Collections.Generic;

namespace VehicleTask
{
    class Program
    {

        static string[] colors = { "red", "blue",
                        "black", "yellow" };
        static List<string> colorsRange = new List<string>(colors);

        public static string ColorValidation()
        {    bool found = false;
            string color;
            Console.WriteLine("Please choose from the following colors: \nRed\nBlue\nBlack\nYellow");
            color = Console.ReadLine();
            while (!found)
            {
                if (colorsRange.Contains(color.ToLower())){
                    found = true;
                }
                else {
                    Console.WriteLine("Invalid entry please choose from the list.");
                    color = Console.ReadLine(); 
                }
            }
            return color;
        }
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
        
        /*public static string PickColor()
        {
            Console.WriteLine("Please choose a color");
            string color = Console.ReadLine();
            color.ToLower();
            foreach(var colors in colorsRange)
            {
                if (colors.Equals(colors))
                    return color;

            }
            Console.WriteLine("Color is not part of the list, please try again.");
            PickColor()
        }*/
        static void Main(string[] args)
        {
            Tire tire = new Tire("Pirelli", 22.5, 3.2, 45.3); 
            Console.WriteLine("Choose your vehicle: \n Press 1 for car, 2 for motorcycle");
            string input = Console.ReadLine();
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
                            Sedan sedan = new Sedan(ColorValidation(), 4, 323, 520, 255, 2000, 150, 300, 100, tire);
                            WriteInfo(sedan);
                            while (sedan.Actions())
                            {

                            }
                            
                            break;


                        case (int)CarType.SUV:
                            
                            SUV suv = new SUV(ColorValidation(), 4, 323, 520, 255, 2000, 150, 300, 100, tire);
                            WriteInfo(suv);
                            while (suv.Actions())
                            {

                            }
                            break;

                        case (int)CarType.Truck:
                            Truck truck = new Truck(ColorValidation(), 6, 323, 520, 255, 2000, 150, 300, 100, tire);
                            WriteInfo(truck);
                            while (truck.Actions())
                            {

                            }
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
                            Motorcycle motorcycle = new Motorcycle(ColorValidation(), 2, 323, 520, 255, 2000, 150, 300, 100, tire);
                            WriteInfo(motorcycle);
                            while (motorcycle.Actions())
                            {

                            }
                            break;

                        case (int)MotorcycleType.Tricycle:
                            Tricycle tricycle = new Tricycle(ColorValidation(), 3, 323, 520, 255, 2000, 150, 300, 100, tire);
                            WriteInfo(tricycle);
                            while (tricycle.Actions())
                            {

                            }
                            break;

                    }
                    break;

            }
        }
    }
}
