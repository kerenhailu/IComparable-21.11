using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare21._11
{
    internal class Truck :Car 
    {
        int numberOfSeats;
        string name;
        public Truck(string model, int volumeEngine, string color ,int numberOfSeats,string name) : base(model, volumeEngine, color)
        {
            this.numberOfSeats = numberOfSeats;
            this.name = name;
            Console.WriteLine(model, volumeEngine, color , numberOfSeats, name);
        }
       
    }
}

