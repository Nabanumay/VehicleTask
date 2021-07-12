using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTask.Car;
using VehicleTask.Vehicle;
using VehicleTask;

namespace Car
{
    internal class Truck : Vehicle
    {
        public Truck(string color, int noOfWheels, int power, int gasMileage, int torque, double weight, double height, double length, double width, Tire t) : base(color, noOfWheels, power, gasMileage, torque, weight, height, length, width, t)
        {
            this.type = "Truck";
        }
       
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
