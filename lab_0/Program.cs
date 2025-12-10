using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;





namespace lab_0
{
    internal class Program
    {
        //task_1
        static void task_1()
        {
            Console.Write("\nЗадание 1: ");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.Write('\n');
        }

        //task_2
        static void task_2()
        {
            Console.WriteLine("\nЗадание 2: ");

            string M, N;
            int m, n;

            Console.WriteLine("Введите число m:");
            M = Console.ReadLine();
            m = Convert.ToInt16(M);

            Console.WriteLine("Введите число n:");
            N = Console.ReadLine();
            n = Convert.ToInt16(N);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(8);
                }
                Console.Write("\n");
            }
        }

        //task_3
        static void task_3()
        {
            Console.WriteLine("\nЗадание 3: ");

            string K;
            int k;

            Console.WriteLine("Введите число k:");
            K = Console.ReadLine();
            k = Convert.ToInt16(K);

            if (k < 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(" ОШИБКА ");
                Console.ResetColor();
                return;
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(8);
                }
                Console.Write("\n");
            }

        }

        //task_4
        static void task_4()
        {
            Console.WriteLine("\nЗадание 4: ");

            string A, B;
            int a, b;

            Console.WriteLine("Введите первое число: ");
            A = Console.ReadLine();
            a = Convert.ToInt16(A);

            Console.WriteLine("Введите второе число: ");
            B = Console.ReadLine();
            b = Convert.ToInt16(B);

            Console.WriteLine("Минимальное число: " + MIN_task_4(a, b));

        }
        static int MIN_task_4(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        //task_5
        static void task_5()
        {
            Console.WriteLine("\nЗадание 5: ");

            string A, B;

            Console.WriteLine("Введите первое имя: ");
            A = Console.ReadLine();

            Console.WriteLine("Введите второе имя: ");
            B = Console.ReadLine();

            if (A == B)
            {
                Console.WriteLine("Имена индентичны");
                return;
            }
            if (A.Length == B.Length)
            {
                Console.WriteLine("Длины имен равны");
                return;
            }
        }

        //task_6
        static void task_6()
        {
            Console.WriteLine("\nЗадание 6: ");

            int[] nums = new int[4];
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(0, 20);
            }
            Console.Write("Массив случайных чисел: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(" ");

            int a, b, c, d;
            a = nums[0];
            b = nums[1];
            c = nums[2];
            d = nums[3];

            Console.WriteLine("Минимальное число: " + MIN_task_6(a, b, c, d));

        }
        static int MIN_task_6(int a, int b, int c, int d)
        {
            int left = MIN_task_4(a, b);
            int right = MIN_task_4(c, d);
            return MIN_task_4(left, right);
        }

        //task_7
        static void task_7()
        {
            Console.WriteLine("\nЗадание 7: ");

            string X, Y;
            int x, y;

            Console.WriteLine("Введите X координату: ");
            X = Console.ReadLine();
            x = Convert.ToInt16(X);

            Console.WriteLine("Введите Y координату: ");
            Y = Console.ReadLine();
            y = Convert.ToInt16(Y);

            if ((x == 0 && y == 0) || x == 0 || y == 0)
            {
                Console.WriteLine("Точка не должна лежать на оси");
                return;
            }
            if (x > 0 && y > 0)
            {
                Console.WriteLine(x + " " + y + ": I");
                return;
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine(x + " " + y + ": II");
                return;
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine(x + " " + y + ": III");
                return;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine(x + " " + y + ": IV");
                return;
            }
        }

        //task_8
        static void task_8()
        {
            Console.WriteLine("\nЗадание 8: ");

            int[] a = new int[10];
            int step = 2;

            for (int i = 0; i < 10; i++)
            {
                a[i] = step;
                step += 2;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i] + "\n");
            }
        }

        //task_9
        static void task_9()
        {
            Console.WriteLine("\nЗадание 9: ");

            int[] a = new int[50];
            int step = 1;

            for (int i = 0; i < 50; i++)
            {
                a[i] = step;
                step += 2;
            }
            for (int i = 0; i < 50; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Write("||| ");
            for (int i = 49; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine(" ");
        }

        //task_10
        static void task_10()
        {
            Console.WriteLine("\nЗадание 10: ");

            int[] nums = new int[15];
            int counter = 0;

            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                int a = random.Next(0, 9);
                nums[i] = a;
                if (a % 2 == 0)
                {
                    counter++;
                }
            }
            Console.Write("Массив случайных чисел: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");

            }
            Console.WriteLine(" ");
            Console.WriteLine("Четных чисел: " + counter);
        }

        //task_11
        static void task_11()
        {
            Console.WriteLine("\nЗадание 11: ");

            int[,] nums = new int[5, 8];

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    nums[i, j] = random.Next(10, 99);
                }
            }
            Console.Write("Массив случайных чисел: \n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
        }

        //task_12
        static void task_12()
        {
            Console.WriteLine("\nЗадание 12: ");

            int[,] nums = new int[4, 7];
            int[] results = new int[4];
            int a = 1;
            int max = -1;
            int max_index = 0;

            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    nums[i, j] = random.Next(-5, 5);
                    a = a * Math.Abs(nums[i, j]);
                }
                results[i] = a;
                if (a > max)
                {
                    max = a;
                    max_index = i;
                }
                a = 1;
            }
            Console.Write("Массив случайных чисел: \n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(nums[i, j] + " ");
                }
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(results[i]);
                Console.ResetColor();
                Console.WriteLine(" ");
            }
            Console.WriteLine("Максимальное произведение элементов находится в " + (max_index + 1) + " строке" + "\n");
        }

        //task_13
        static void task_13()
        {
            Console.WriteLine("\nЗадание 13: ");

            int[] nums = new int[20];
            string A, B;
            int a, b;

            Console.WriteLine("Введите a: ");
            A = Console.ReadLine();
            a = Convert.ToInt16(A);

            Console.WriteLine("Введите b: ");
            B = Console.ReadLine();
            b = Convert.ToInt16(B);

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Rand_task_13(a, b); ;

            }
            Console.Write("Массив случайных чисел: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");

            }
            Console.WriteLine(" ");
        }
        static int Rand_task_13(int a, int b)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode()); //честно, несовсем понимаю, как это работает
            int result = random.Next(a, b);
            return result;
        }

        //task_14
        static void task_14()
        {
            Console.WriteLine("\nЗадание 14: ");

            int[] one = new int[10];
            int[] two = new int[10];
            int[] three = new int[10];
            int[] four = new int[10];
            int[] five = new int[10];
            Fill_task_14(one, 0, 15);
            Fill_task_14(two, -15, 30);
            Fill_task_14(three, 26, 99);
            Fill_task_14(four, -100, 0);
            Fill_task_14(five, 39, 151);
        }
        static void Fill_task_14(int[] arr, int a, int b)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Rand_task_13(a, b);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine(" ");
        }

        //task_15
        static void task_15()
        {
            Console.WriteLine("\nЗадание 15: ");
            int[] arr = new int[15];
            Console.WriteLine("Неотсортированный массив: ");
            Fill_task_14(arr, 0, 25);
            Console.WriteLine("Отсортированный массив: ");
            Sort_task_15(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine(" ");

        }
        static void Sort_task_15(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = arr[left];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j)
                Sort_task_15(arr, left, j);
            if (i < right)
                Sort_task_15(arr, i, right);
        }

        //task_16
        static void task_16()
        {
            Console.WriteLine("\nЗадание 16: ");
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            Fib_task_16(0, 1, 1, number);
            //¯\_(ツ)_/¯
            //P.S. У меня все считает, довести до стаковерфлоу можно, но с 47 уже не правильно начинает выводить (по-моему)
            //Process is terminated due to StackOverflowException. 10000
        }
        static void Fib_task_16(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number)
                Fib_task_16(b, a + b, counter + 1, number);
        }

        static void ask_task(int a)
        {
            Action[] tasks = { task_1, task_2, task_3, task_4, task_5, task_6, task_7, task_8,
                       task_9, task_10, task_11, task_12, task_13, task_14, task_15, task_16 };
            if (a >= 1 && a <= 16) tasks[a - 1]();
        }


        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string A;
                int a;
                Console.WriteLine("==============================");
                Console.WriteLine("Введите номер задания (1-16): ");
                A = Console.ReadLine();
                try
                {
                    a = Convert.ToByte(A);
                    ask_task(a);
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ОШИБКА ");
                    Console.ResetColor();
                }

            }

        }
    }
}