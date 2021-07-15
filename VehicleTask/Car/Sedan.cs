using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTask;
using VehicleTask.Car;
using VehicleTask.Vehicle;

namespace Car
{
    public class Sedan : Vehicle, ISunroof
    {
        bool sunroofOpen = false;

        public Sedan(string color, int noOfWheels, int power, int gasMileage, int torque, double weight, double height, double length, double width, Tire t) : base(color, noOfWheels, power, gasMileage, torque, weight, height, length, width, t)
        {
            this.type = "Sedan";
        }

        public bool Actions()
        {
            int choice;
            Console.WriteLine("What would you like to do with your sedan?");
            Console.WriteLine("Press 1 to move");
            Console.WriteLine("Press 2 to press the sunroof button.");
            Console.WriteLine("Press 0 to exit");
            
            var input = Console.ReadLine();
            try
            {
                choice = int.Parse(input);



                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Press F for forward, B for backward, L for left, R for right.");
                        Console.WriteLine(this.Move(Convert.ToChar(Console.ReadLine())));
                        return true;

                    case 2:
                        Console.WriteLine(this.PressSunroofButton());
                        return true;

                    case 0:
                        Console.WriteLine("Exiting vehicle.");
                        return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Entry, please enter an integer.TEST");
                return true;
            }

            return true;
        }

        public string PressSunroofButton()
        {
            if(sunroofOpen == false)
            {
                sunroofOpen = true;
                return "Opening sunroof now.";
            }
            else
            {
                sunroofOpen = false;
                return "Closing sunroof now.";
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
