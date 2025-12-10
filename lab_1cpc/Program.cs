using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_1cpc
{
    //task_1
    class Book
    {
        private string Title;
        private string Author;
        private int Year;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Author} | {Title} | {Year}");
        }
    }

    //task_3
    class BankAccount
    {
        private string accountNumber;
        private string ownerName; 
        private decimal balance;
        static public string BankName = "Народный Банк";

        public BankAccount(string accountNumber, decimal balance, string ownerName)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.ownerName = ownerName; 
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
        public void Transfer(BankAccount target, decimal amount)
        {
            try
            {
                Withdraw(amount);
                target.Deposit(amount);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Перевод {amount} руб. со счета {accountNumber} на счет {target.accountNumber}");
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"{ex.Message} | {ownerName}");
                Console.ResetColor();
            }
        }
    }
    //task_2
    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {

            BankAccount.BankName = "Сберегательный Банк";
            BankAccount bank = new BankAccount("32132b", 1000, "Алексей");
            BankAccount pubg = new BankAccount("182736", 999, "Мария");

            bank.PrintStatement();
            pubg.PrintStatement();
            bank.Transfer(pubg, 500);
            pubg.Transfer(bank, 2000);
            bank.PrintStatement();
            pubg.PrintStatement();

            MathOperations math = new MathOperations();
                int a = math.Add(1, 2);
                int b = math.Add(1, 2, 3);
                double c = math.Add(1.5, 8.0);
                string d = math.Add("Hello ", "привет.");
                Console.WriteLine($"{a}\n{b}\n{c}\n{d}\n");



                List<Book> books = new List<Book>();
                Book maink = new Book("Lorem Ipsum", "John Doe", 2025);
                Book kamph = new Book("Agusha", "Real Wassup", 1984);
                Book bulba = new Book("Potatbro", "idk", 01);
                Book jora = new Book("Anton.", "Jora Petin", 2000);

                books.Add(maink);
                books.Add(kamph);
                books.Add(bulba);
                books.Add(jora);

                books.Remove(kamph);

                for (int i = 0; i < books.Count; i++)
                {
                    Book book = books[i];
                    book.DisplayInfo();
                }

                Console.WriteLine();

                


        }
        }
}

