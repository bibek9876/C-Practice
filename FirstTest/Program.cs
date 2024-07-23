// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace FirstTest
{

    /*class Car
    {
        public string color = "red";

    }*/
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bibek Shrestha";
            int a = 12;
            double b = a;
            Console.WriteLine(b);

            double myDouble = 1.23;
            int myInt = (int)myDouble;
            Console.WriteLine(myInt);
            Console.WriteLine(name);
            try
            {
                Console.WriteLine("Enter your Username:");
                string userName = Console.ReadLine();

                Console.WriteLine("Your username is:" + userName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }


            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 90)
            {
                throw new ArithmeticException("Your age cannot be more than 90 years old");
            }
            else
            {

                Console.WriteLine("Your guess age is: " + age);
            }
            int myAge = 25;

            if (age == myAge)
            {
                Console.WriteLine("Your Guess is right.");
            }
            else
            {
                Console.WriteLine("Your Guess is wromng");
            }
            //Console.WriteLine(myAge == age);


            //Ternery Operation

            String ageResult = (age == myAge) ? "Your guess is right." : "Your guess is wrong";
            Console.WriteLine(ageResult);
            string firstName = "Bibek ";
            string lastName = "Shrestha";

            //Switch statement

            switch (age)
            {
                case 24:
                    Console.WriteLine("You are close");
                    break;
                case 25:
                    Console.WriteLine("your guess is right");
                    break;
                default:
                    Console.WriteLine("The age was 25");
                    break;
            }

            //While statement
            int intWhile = 1;
            while(intWhile < 10)
            {
                Console.WriteLine(intWhile);
                intWhile++;
            }

            //Do....while statement
            int intDoWhile = 5;

            do
            {
                Console.WriteLine(intDoWhile);
                intDoWhile--;
            }
            while (intDoWhile > 5);

            //for loop
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine(i);
            }

            //nested for loop
            for (int i =1; i<5; i++)
            {
                Console.WriteLine(i);
                for (int j = 1; j<4; j++)
                {
                    Console.WriteLine(j);
                }
            }


            //foreach loop

            string[] names = { "A", "B", "C" };
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }


            string fullName = $"Your fullname is: {firstName} {lastName}";
            Console.WriteLine(fullName);

            string newName = firstName + lastName;
            int charPos = newName.IndexOf("S");
            string newLastName = newName.Substring(charPos);
            Console.WriteLine(newLastName);

            string txt = $"\"{newName}\" is the main character.";
            Console.WriteLine(txt);

            //Classes and Objects

            Car myObj = new Car(2024);
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            myObj.FullThrottle();
            Console.WriteLine(myObj.model);
            Console.WriteLine(myObj.year);

            //property obj
            Car property = new Car(2024);
            property.Name = "Focus";
            Console.WriteLine(property.Name);

            //inheritance
            Console.WriteLine("Example of inheritance");

            Car inherit = new Car(2024);
            inherit.honk();

            Console.WriteLine(inherit.brand + "  " + inherit.modelName);

            //polymorphism
            Console.WriteLine("This is an example for polymorphism");
            Animal animal = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();
            animal.animalSound();
            pig.animalSound();
            dog.animalSound();

            //interface
            Console.WriteLine("THis is an example for interface");
            Pegion pegion = new Pegion();
            pegion.birdName();

            //Enumerators
            Console.WriteLine("This is an example for enums:");
            int month = (int)Months.February;
            Console.WriteLine(month);

            //working with files
            string writeText = "This is a new test file.";
            File.WriteAllText("testfile.txt", writeText);

            string readText = File.ReadAllText("testfile.txt");
            Console.WriteLine(readText);
        }
    }

   

}
