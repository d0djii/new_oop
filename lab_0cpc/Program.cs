using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_0cpc
{
    //task_1
    /*class Student
    {
        public string Name;
        public int StudentId;
        public string Group;

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {Name}, ID: {StudentId}, Группа: {Group}");
        }
    }*/

    //task_2
    class Student
    {
        private string Name;
        private int StudentId;
        private string Group;
        public Student(string name, int id, string group)
        {
            this.Name = name;
            this.StudentId = id;
            this.Group = group;
        }

        public string name { get { return this.Name; } set { Name = value; } }
        public int studentid { get { return this.StudentId; } set { StudentId = value > 0 ? value : throw new ArgumentException("ID должен быть > 0"); } }
        public string group { get { return this.Group; } set { Group = value; } }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {Name}, ID: {StudentId}, Группа: {Group}");
        }

    }

    //task_3
    class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        static public string BankName = "Народный Банк";

        public BankAccount(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            this.balance = amount > 0 ? this.balance + amount : throw new ArgumentException("Мало");
        }
        public void Withdraw(decimal amount)
        {
            this.balance = amount <= this.balance ? this.balance - amount : throw new ArgumentException("Недостаточно средств");
        }
        public void PrintStatement()
        {
            Console.WriteLine($"Банк: {BankName}, Счет: {accountNumber}, Баланс: {balance}");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            /*Student student = new Student();
            student.Name = "Bebra";
            student.StudentId = 1;
            student.Group = "ФИЛ91б";
            student.PrintInfo();*/

            Student jhny = new Student("John", 33, "ПИ41б");
            Student alx = new Student("Леха", 34, "1521б");
            jhny.group = "idk";
            //alx.studentid = -1; //Необработанное исключение: System.ArgumentException: ID должен быть > 0
            alx.studentid = 2;
            jhny.PrintInfo(); //Студент: John, ID: 33, Группа: idk
            alx.PrintInfo(); //Студент: Леха, ID: 2, Группа: 1521б

            BankAccount.BankName = "Сберегательный Банк";
            BankAccount bank = new BankAccount("32132b", 1000);

            bank.Deposit(1);
            //bank.Deposit(-1);    //Необработанное исключение: System.ArgumentException: Мало
            bank.Withdraw(1000);
            //bank.Withdraw(1002); //Необработанное исключение: System.ArgumentException: Недостаточно средств
            bank.PrintStatement(); //Банк: Сберегательный Банк, Счет: 32132b, Баланс: 1
            

        }
    }
}
