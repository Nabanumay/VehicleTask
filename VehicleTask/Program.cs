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
                {
                    return true;
                }
            }
            if (level == 1)
                Console.WriteLine("Invalid entry, Enter 1 for car, 2 for motorcycle");

            else if (level == 2 && range == 3)
                Console.WriteLine("Invalid entry, enter 1 for sedan, 2 for SUV, 3 for truck");

            else
                Console.WriteLine("Invalid entry, enter 1 for motorcycle, 2 for tricycle");

            return false;

        }
        public static void WriteInfo(Vehicle.Vehicle c)
        {
            Console.WriteLine(c.ToString());
            Console.WriteLine(c.Move('F'));
            Console.WriteLine(c.Move('B'));
            Console.WriteLine(c.Move('L'));
            Console.WriteLine(c.Move('R'));
            

        }
        public static string PickColor()
        {
            Console.WriteLine("Please choose a color");
            return Console.ReadLine();
        }

        
        static void Main(string[] args)
        {
            Tire t = new Tire("Pirelli", 22.5, 3.2, 45.3); 
            Console.WriteLine("Choose your vehicle: \n Press 1 for car, 2 for motorcycle");
            string input = Console.ReadLine();
            int choice;
             while (!Validation(input, 2, 1))
            { 
                input = Console.ReadLine();
             }

            choice = int.Parse(input);
            switch (choice)
            {
                case (int)VehicleType.Car:
                    Console.WriteLine("Choose your car: \nPress 1 for Sedan, 2 for SUV, 3 for Truck");
                    input = Console.ReadLine();
                    while (!Validation(input, 3, 2))
                    {
                        input = Console.ReadLine();
                    }
                    choice = int.Parse(input);
                    switch (choice)
                    {
                        case (int)CarType.Sedan:
                            Sedan sedan = new Sedan(PickColor(), 4, 323, 520, 255, 2000, 150, 300, 100, t);
                            WriteInfo(sedan);
                            Console.WriteLine(t.ToString());
                            Console.WriteLine(sedan.pressSunroofButton()+"\n"+sedan.pressSunroofButton());
                            break;


                        case (int)CarType.SUV:
                            SUV suv = new SUV(PickColor(), 4, 323, 520, 255, 2000, 150, 300, 100, t);
                            WriteInfo(suv);
                            Console.WriteLine(t.ToString());
                            Console.WriteLine(suv.pressSunroofButton() + "\n" + suv.pressSunroofButton());
                            break;

                        case (int)CarType.Truck:
                            Truck truck = new Truck(PickColor(), 6, 323, 520, 255, 2000, 150, 300, 100, t);
                            WriteInfo(truck);
                            Console.WriteLine(t.ToString());
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
                    choice = int.Parse(input);
                    switch (choice)
                    {
                        case (int)MotorcycleType.Motorcycle:
                            Motorcycle motorcycle = new Motorcycle(PickColor(), 2, 323, 520, 255, 2000, 150, 300, 100, t);
                            WriteInfo(motorcycle);
                            Console.WriteLine(t.ToString());
                            break;

                        case (int)MotorcycleType.Tricycle:
                            Tricycle tricycle = new Tricycle(PickColor(), 3, 323, 520, 255, 2000, 150, 300, 100, t);
                            WriteInfo(tricycle);
                            Console.WriteLine(t.ToString());
                            break;

                    }
                    break;

            }
        }
    }
}
