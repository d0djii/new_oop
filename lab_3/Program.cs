
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    // // Polimorf
    //task_1&2
    class Whale
    {
        public string getName()
        {
            return "Я не корова, Я - кит";
        }
    }
    class Cow
    {
        public string getName()
        {
            return "Я - корова";
        }
    }

    //task_3&4
    class Cat
    {
        protected string pet_name;

        public Cat(string name)
        {
            pet_name = name;
        }

        public virtual void getChild()
        {
            Console.WriteLine($"{pet_name} порождает кота");
        }
    }
    class Dog : Cat
    {
        public Dog(string name) : base(name)
        {

        }

        public override void getChild()
        {
            Console.WriteLine($"{pet_name} порождает собаку");
        }
    }

    class Bird
    {
    }
    class Lamp
    {
    }


    internal class Program
    {
        static void Typeof_obj(object _object)
        {
            if (_object is Cat)
                Console.WriteLine("Кошка");
            else if (_object is Dog)
                Console.WriteLine("Собака");
            else if (_object is Bird)
                Console.WriteLine("Птица");
            else if (_object is Lamp)
                Console.WriteLine("Лампа");
            else
                Console.WriteLine("Что-то пошло не так");
        }

        

        static void Main(string[] args)
        {
            // //Polimorf
            /*task_1&2
            Whale whale = new Whale();
            Cow cow = new Cow();
            Console.WriteLine(whale.getName());
            Console.WriteLine(cow.getName());
            */

            /*task_3
            Cat cat = new Cat("bagira");
            Dog dog = new Dog("ambal");
            Bird bird = new Bird();
            Lamp lamp = new Lamp();

            Typeof_obj(cat);
            Typeof_obj(dog);
            Typeof_obj(bird);
            Typeof_obj(lamp);
            

            //task_4
            Cat cat1 = new Cat("Мася");
            Dog dog1 = new Dog("Лаки");

            dog1.getChild();
            cat1.getChild();
            */


            // //Overloading
            //task_1&2&3
            print(12);
            print("bebra");
            print(1.15);
            print('a');
            print(false);

            Console.WriteLine();

            //task_4&5
            Console.WriteLine($"min из int'ов: " +
                $"{min(10, 23)}");
            Console.WriteLine($"min из long'ов: " +
                $"{min(-9147483648, 2500000000)}");
            Console.WriteLine($"min из double'ов: " +
                $"{min(10.44, 2.4)}");
            Console.WriteLine($"max из int'ов: " +
                $"{max(10, 23)}");
            Console.WriteLine($"max из long'ов: " +
                $"{max(-9147483648, 2500000000)}");
            Console.WriteLine($"max из double'ов: " +
                $"{max(10.44, 2.4)}");
        }

        // //Overloading
        //task_1&2&3
        static void print(int num)
        {
            Console.WriteLine($"int: {num}");
        }
        static void print(string str)
        {
            Console.WriteLine($"str: {str}");
        }
        static void print(double dbl)
        {
            Console.WriteLine($"double: {dbl}");
        }
        static void print(char chr)
        {
            Console.WriteLine($"char: {chr}");
        }
        static void print(bool boolean)
        {
            Console.WriteLine($"bool: {boolean}");
        }

        //task_4&5
        public static int min(int a, int b)
        {
            return Math.Min(a, b);
        }
        public static long min(long a, long b)
        {
            return Math.Min(a, b);
        }
        public static double min(double a, double b)
        {
            return Math.Min(a, b);
        }

        public static int max(int a, int b)
        {
            return Math.Max(a, b);
        }
        public static long max(long a, long b)
        {
            return Math.Max(a, b);
        }
        public static double max(double a, double b)
        {
            return Math.Max(a, b);
        }

    }
}
