using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare21._11
{
    internal class Bus : Car
    {
        //public Bus() { }
        public Bus(string model, int volumeEngine, string color) :base(model,volumeEngine,color)
        {
            Console.WriteLine(model, volumeEngine, color);
        }

       

        int numberOfSeats;
        string company;

        public int NumberOfSeats { get; set; }
        //{
        //    get { return this.numberOfSeats; }
        //    set { this.numberOfSeats = value; }
        //}
        public string Company { get; set; }
        //{
        //    get { return this.company; }
        //    set { this.company = value; }
        //}
    }
}
