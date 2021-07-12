﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTask.Vehicle
{
    public class Vehicle : IMovement
    {
        public string type
        {
            get;
            set;
        }
        public string color
        {
            get;
            set;
        }
        public int noOfWheels
        {
            get;
            set;
        }
        public int gasMileage
        {
            get;
            set;
        }
        public int power
        {
            get;
            set;
        }
        public int torque
        {
            get;
            set;
        }
        public double weight
        {
            get;
            set;
        }
        public double height
        {
            get;
            set;
        }
        public double length
        {
            get;
            set;
        }
        public double width
        {
            get;
            set;
        }

        public Vehicle(string color, int noOfWheels, int power, int gasMileage,
            int torque, double weight, double height, double length, double width, Tire t)
        {
            this.color = color;
            this.power = power;
            this.noOfWheels = noOfWheels;
            this.gasMileage = gasMileage;
            this.torque = torque;
            this.weight = weight;
            this.height = height;
            this.length = length;
            this.width = width;
            
        }

        public override string ToString()
        {
            return "Type: " + type + "\nColor: " + color + "\nNumber of wheels: " + noOfWheels + "\nPower: " + power + "HP\nTorque: " + torque +
                "Nm\nGas mileage: " + gasMileage + "km\nWeight: " + weight + "kg\nHeight " + height + "cm\nLength: " + length + "cm\nWidth: " + width+"cm";
        }

        public string Move(char direction)
        {
            char upper = char.ToUpper(direction);
            if (upper == 'F')
            {
                return "You have moved forward.";
            }

            else if (upper == 'B')
            {
                return "You have moved Backwards.";
            }

            else if (upper == 'R')
            {
                return "You have moved forward.";
            }

            else if (upper == 'F')
            {
                return "You have moved forward.";
            }

            else
            {
                return "Incorrect entry, try again.";
            }
        }

       
    }
}

    public enum VehicleType
{
    Car = 1,
    Motorcycle = 2
}

    public enum CarType
{
    Sedan = 1,
    SUV = 2,
    Truck = 3
}

    public enum MotorcycleType
{
    Motorcycle = 1,
    Tricycle = 2
}