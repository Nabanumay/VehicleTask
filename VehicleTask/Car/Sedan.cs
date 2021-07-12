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


        public string pressSunroofButton()
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
