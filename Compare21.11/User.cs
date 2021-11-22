using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare21._11
{
    internal class User : IComparable
    {
        string name;
        string email;
        int yearOld;
       public User(string name,string email,int yearOld)
        {
            this.name=name;
            this.email=email;
            this.yearOld=yearOld;
        }
        public User() { }
        public void Print()
        {
            Console.WriteLine($"{this.name}");
            Console.WriteLine($"{this.email}");
            Console.WriteLine($"{this.yearOld}");
        }
        public int CompareTo(object? obj)
        {
            User c = (User)obj;
            if (this.yearOld < c.yearOld)
                return -1;
            if (this.yearOld > c.yearOld)
                return 1;
            return 0;
        }
    }
}
