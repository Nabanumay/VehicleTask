using VehicleTask.Vehicle;
using VehicleTask;

namespace Motorbike
{
    class Tricycle : Vehicle
    {
        public Tricycle(string color, int noOfWheels, int power, int gasMilage, int torque, double weight, double height, double length, double width, Tire t) : base(color, noOfWheels, power, gasMilage, torque, weight, height, length, width, t)
        {
            this.type = "Tricycle";
        }

        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}