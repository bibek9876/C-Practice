using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    class Car
    {
        public string color = "red";
        public int maxSpeed;
        public string model;
        public int year;

        //Method
        public void FullThrottle()
        {
            Console.WriteLine("The car is going in a full speed.");
        }

        //Constructor of a class Car()
        public Car(int buildYear)
        {
            model = "Mustang";
            year = buildYear;
        }

    }
}
