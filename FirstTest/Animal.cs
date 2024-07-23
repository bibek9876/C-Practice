using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("THis is animal class");
        }
    }

    class Pig:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("This is a pig class");
        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("This is a dog class");
        }
    }

    //interface
    interface IBird 
    {
        void birdName(); //Interface method does not have a body
    }

    class Pegion : IBird //Inherit interface
    {
        public void birdName()
        {
            Console.WriteLine("This is inheritated from an interface");
        }
    }

    //enumerators
    enum Months
    {
        January,
        February,
        March,
        April
    }

}
