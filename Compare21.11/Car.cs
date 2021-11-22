using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare21._11
{
    internal class Car: IComparable
    {
       
        public string model;
        public int volumeEngine;
        public string color;
        public Car(string model, int volumeEngine , string color)
        {
            this.model = model;
            this.volumeEngine = volumeEngine;
            this.color = color;
        }
        public void PrintDetails()
        { 
            Console.WriteLine($"{this.model}");
            Console.WriteLine($"{this.volumeEngine}");
            Console.WriteLine($"{this.color}");

        }
        //int CompareTo(object obj)
        //{
        //    Car c = (Car)obj;
        //    if (this.volumeEngine < c.volumeEngine)
        //        return -1;
        //    if (this.volumeEngine > c.volumeEngine)
        //        return 1;
        //    return 0;

        //}

        public int CompareTo(object? obj)
        {
            Car c = (Car)obj;
            if (this.volumeEngine < c.volumeEngine)
                return -1;
            if (this.volumeEngine > c.volumeEngine)
                return 1;
            return 0;
        }
    }
}

