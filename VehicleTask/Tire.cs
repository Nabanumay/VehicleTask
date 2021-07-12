using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTask
{
    public class Tire
    {

        public string tireType
        {
            get;
            set;
        }
        public double tireSize
        {
            get;
            set;
        }

        public double tirePressure
        { 
            get;
            set;
        }

        public double tireTemperature
        {
            get;
            set;
        }
        public Tire(string newType, double newSize, double newPressure, double newTemp)
        {
            tireType = newType;
            tireSize = newSize;
            tirePressure = newPressure;
            tireTemperature = newTemp;
        }
        public override string ToString()
        {
            return "Tire type: " + tireType + "\nTire size: " + tireSize + "inches\nTire pressure: " + tirePressure + "bar\nTire temperature: " + tireTemperature+"C";
        }


    }
}
