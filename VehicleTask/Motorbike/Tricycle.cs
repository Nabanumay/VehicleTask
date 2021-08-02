using VehicleTask.Vehicle;
using VehicleTask;
using System;

namespace Motorbike
{
    class Tricycle : Vehicle
    {
        public Tricycle(string color, int noOfWheels, int power, int gasMilage, int torque, double weight, double height, double length, double width, Tire t) : base(color, noOfWheels, power, gasMilage, torque, weight, height, length, width, t)
        {
            this.type = "Tricycle";
        }


        public bool Actions()
        {
            int choice;
            string input;
            Console.WriteLine("What would you like to do with your tricycle?");
            Console.WriteLine("Press 1 to move");
            Console.WriteLine("Press 0 to exit");
            input = Console.ReadLine();

            try
            {
                choice = int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Entry, please enter an integer.");
                return true;
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Press F for forward, B for backward, L for left, R for right.");
                    Console.WriteLine(this.Move(Convert.ToChar(Console.ReadLine())));
                    return true;

                case 0:
                    Console.WriteLine("Exiting vehicle.");
                    return false;
            }
            return true;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}