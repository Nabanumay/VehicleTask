using Car;
using Motorbike;
using System;

namespace VehicleTask
{
    class Program
    {

        public static bool Validation(string input, int range)
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
            Console.WriteLine("Invalid entry, enter 1 for car, 2 for motorcycle");
            return false;

        }
        static void Main(string[] args)
        {
            Tire t = new Tire("Pirelli", 22.5, 3.2, 45.3); 
            string color;
            Console.WriteLine("Choose your vehicle: \n Press 1 for car, 2 for motorcycle");
            string input = Console.ReadLine();
            int choice = 0;
             while (!Validation(input, 2))
             {
                input = Console.ReadLine();
             }

            choice = int.Parse(input);
            switch (choice)
            {
                case (int)VehicleType.Car:
                    Console.WriteLine("Choose your car: \nPress 1 for Sedan, 2 for SUV, 3 for Truck");
                    input = Console.ReadLine();
                    while (!Validation(input, 3))
                    {
                        input = Console.ReadLine();
                    }
                    choice = int.Parse(input);
                    switch (choice)
                    {
                        case (int)CarType.Sedan:
                            Console.WriteLine("Please choose a color");
                            color = Console.ReadLine();
                            Sedan sedan = new Sedan(color, 4, 323, 520, 255, 2000, 150, 300, 100, t);
                            Console.WriteLine(sedan.ToString());
                            Console.WriteLine(t.ToString());
                            Console.WriteLine(sedan.pressSunroofButton()+"\n"+sedan.pressSunroofButton());
                            break;


                        case (int)CarType.SUV:
                            Console.WriteLine("Please choose a color");
                            color = Console.ReadLine();
                            SUV suv = new SUV(color, 4, 323, 520, 255, 2000, 150, 300, 100, t);
                            Console.WriteLine(suv.ToString());
                            Console.WriteLine(t.ToString());
                            Console.WriteLine(suv.pressSunroofButton() + "\n" + suv.pressSunroofButton());
                            break;

                        case (int)CarType.Truck:
                            Console.WriteLine("Please choose a color");
                            color = Console.ReadLine();
                            Truck truck = new Truck(color, 6, 323, 520, 255, 2000, 150, 300, 100, t);
                            Console.WriteLine(truck.ToString());
                            Console.WriteLine(t.ToString());
                            break;
                    }
                    break;

                case (int)VehicleType.Motorcycle:
                    Console.WriteLine("Choose your Motorcycle: \nPress 1 for Motorcycle, 2 for Tricycle");
                    input = Console.ReadLine();
                    while (!Validation(input, 2))
                    {
                        input = Console.ReadLine();
                    }
                    choice = int.Parse(input);
                    switch (choice)
                    {
                        case (int)MotorcycleType.Motorcycle:
                            Console.WriteLine("Please choose a color");
                            color = Console.ReadLine();
                            Motorcycle motorcycle = new Motorcycle(color, 4, 323, 520, 255, 2000, 150, 300, 100, t);
                            Console.WriteLine(motorcycle.ToString());
                            Console.WriteLine(t.ToString());
                            break;

                        case (int)MotorcycleType.Tricycle:
                            Console.WriteLine("Please choose a color");
                            color = Console.ReadLine();
                            Tricycle tricycle = new Tricycle(color, 4, 323, 520, 255, 2000, 150, 300, 100, t);
                            Console.WriteLine(tricycle.ToString());
                            Console.WriteLine(t.ToString());
                            break;

                    }
                    break;

            }
        }
    }
}
