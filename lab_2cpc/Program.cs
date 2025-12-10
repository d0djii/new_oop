using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace lab_2cpc
{
    //task_1
    
    class Transport
    {
        public string Name;
        public int MaxSpeed;

        public Transport(string name, int maxspeed)
        {
            Name = name;
            MaxSpeed = maxspeed;
        } 
    }

    class Car : Transport
    {
        public int DoorCount;

        public Car(string name, int maxspeed, int doorCount) : base(name, maxspeed)
        {
            DoorCount = doorCount;
        }
    }

    //task_2
    class Employee
    {
        public string Name;
        public decimal Salary;

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}\t{Salary}");
        }
    }

    class Manager : Employee
    {
        public string Department;

        public new void PrintInfo()
        {
            Console.WriteLine($"{Name}\t{Salary}\t{Department}");
        }

    }

    //task_3
    class BankAccount
    {
        protected string AccountNumber;
        protected decimal Balance;

        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void PrintBalance()
        {
            Console.WriteLine(Balance);
        }
    }

    class SavingsAccount : BankAccount 
    {
        decimal InterestRate;

        public SavingsAccount(string accountNumber, decimal balance, decimal interestRate) : base(accountNumber, balance) 
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            Balance += InterestRate;
        }

    }
        
    //task_4
    class Product
    {
        public string Name;
        public decimal Price;

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name}\t{Price}");
        }
    }

    class Food : Product
    {
        public string DateTime;
        public string ExpireDate;

        public Food(string name, decimal price, string dateTime, string expireDate) : base(name, price)
        {
            DateTime = dateTime;
            ExpireDate = expireDate;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name}\t{Price}\t{DateTime}\t{ExpireDate}");
        }
    }

    class Bakery : Food
    {
        public bool IsGluttenFree;

        public Bakery (string name, decimal price, string dateTime, string expireDate, bool isGluttenFree) : base(name, price, dateTime, expireDate)
        {
            IsGluttenFree = isGluttenFree;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name}\t{Price}\t{DateTime}\t{ExpireDate}\t{IsGluttenFree}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //task_4
            Bakery bulka = new Bakery("синабон", 50, "17.06.2025", "20.06.2025", false);
            bulka.DisplayInfo();

            /*task_3
            SavingsAccount acc = new SavingsAccount("123121", 100, 30);
            acc.PrintBalance();
            acc.AddInterest();
            acc.PrintBalance();
            */

            /*task_2
            Employee ehm = new Employee();
            Manager manager = new Manager();
            ehm.Name = "Bebra";
            ehm.Salary = 100;
            manager.Name = "Namal";
            manager.Salary = 200;
            manager.Department = "0_0";

            ehm.PrintInfo();
            manager.PrintInfo();
            */

            /*task_1
            Car bmw = new Car("BMW", 200, 4);
            Console.WriteLine(bmw.Name);
            Console.WriteLine(bmw.MaxSpeed);
            Console.WriteLine(bmw.DoorCount);
            */
        }
    }
}