using System;
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
}
