using VehicleTask.Vehicle;
using VehicleTask;

namespace Motorbike
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string color,
                          int noOfWheels,
                          int power,
                          int gasMileage,
                          int torque,
                          double weight,
                          double height,
                          double length,
                          double width,
                          Tire t) : base(color, noOfWheels, power, gasMileage, torque, weight, height, length, width, t)
        {
            this.type = "Motorcycle";
        }

        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
