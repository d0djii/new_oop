using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{

    //task_1
    class Horse
    {
        protected string name;
        public Horse()
        {
            Console.WriteLine("Введите кличку");
            name = Console.ReadLine();
        }
    }
    class Pegas : Horse
    {
        public void Fly()
        {
            Console.WriteLine($"{name} умеет летать");
        }
    }

    //task_2
    class Pet
    {
        protected int weight;
        protected bool sex;
        protected int age;

        public Pet()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            weight = random.Next(1, 60);
            age = random.Next(1, 40);
            sex = random.Next(2) == 1;
        }
    }
    class Cat : Pet
    {
        private string cat_name = "No_Name";


        public void display_stat()
        {
            Console.WriteLine(" КОТ ");
            Console.WriteLine($"Имя:\t {cat_name} Возраст:\t {age} Вес:\t {weight} Мальчик?: {sex}");
        }

        //task_4
        public void set_name()
        {
            Console.WriteLine("Введите имя: ");
            cat_name = Console.ReadLine();
        }
    }
    class Dog : Pet
    {
        private string dog_name = "No_Name";

        public void display_stat()
        {
            Console.WriteLine(" СОБАКА ");
            Console.WriteLine($"Имя:\t {dog_name} Возраст:\t {age} Вес:\t {weight} Мальчик?: {sex}");
        }
    }

    //task_3
    class Fish
    {
        protected bool skeleton;
        protected bool jabri;

        public Fish()
        {
            skeleton = true;
            jabri = true;
        }

        public void Plob()
        {
            Console.WriteLine("*Буль-Буль-Буль*");
        }
        public void DNA()
        {
            Console.WriteLine($"Скелет = {skeleton}\t Жабры = {jabri}");
        }
    }
    class Animal : Fish
    {
        protected bool mamel;
        protected bool strong_smell;

        public Animal()
        {
            mamel = true;
            strong_smell = true;
            jabri = false;
        }

        public new void DNA()
        {
            Console.WriteLine($"Скелет = {skeleton}\t Жабры = {jabri}\t " +
                $"Млекопитающие = {mamel}\t Сильное обоняние = {strong_smell}");
        }
        public void Cute()
        {
            Console.WriteLine("*Делают что-то милое (зачастую)*");
        }
    }
    class Ape : Animal
    {
        protected bool bipedalism;
        protected bool tail;

        public Ape()
        {
            bipedalism = true;
            tail = true;
            strong_smell = false;
        }

        public new void DNA()
        {
            Console.WriteLine($"Скелет = {skeleton}\t Жабры = {jabri}\t " +
                $"Млекопитающие = {mamel}\t Сильное обоняние = {strong_smell}\t " +
                $"Двуногое = {bipedalism}\t Хвост = {tail}");
        }
        public void Go_crazy()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("УУУУУУУУААААААААА-УАУАУА-УАА-А-ААА");
            Console.ResetColor();
        }
    }
    class Human : Ape
    {
        protected bool self_consciousness;
        protected bool religion;

        public Human()
        {
            self_consciousness = true;
            religion = true;
            tail = false;
        }

        public new void DNA()
        {
            Console.WriteLine($"Скелет = {skeleton}\t Жабры = {jabri}\t " +
                $"Млекопитающие = {mamel}\t Сильное обоняние = {strong_smell}\t " +
                $"Двуногое = {bipedalism}\t Хвост = {tail}\t Самосознание = {self_consciousness}\t" +
                $"Религия: {religion}");
        }
        public void idk()
        {
            Console.WriteLine("idk");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            //task_3
            Animal animal = new Animal();
            animal.DNA();
            Human human = new Human();
            human.DNA();
            human.idk();
            Ape monke = new Ape();
            monke.DNA();
            monke.Go_crazy();
            monke.Cute();

            /*task_1
            Horse horse_1 = new Horse();
            Pegas horse_2 = new Pegas();
            //horse_1.Fly();
            horse_2.Fly();
            */

            /*task_2
            Dog dog_1 = new Dog();
            Dog dog_2 = new Dog();
            Dog dog_3 = new Dog();
            Cat cat_1 = new Cat();
            Cat cat_2 = new Cat();
            Cat cat_3 = new Cat();

            dog_1.display_stat();
            dog_2.display_stat();
            dog_3.display_stat();
            cat_1.display_stat();
            cat_2.display_stat();
            cat_3.display_stat();

            Console.WriteLine();

            //task_4
            Cat cat_4 = new Cat();
            cat_4.display_stat();
            cat_4.set_name();
            cat_4.display_stat();
            */






        }
    }
}