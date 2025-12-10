using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{

    class Circle
    {
        //task_3
        public Circle(double x_0, double y_0, double radius)
        {
            this.x_0 = x_0;
            this.y_0 = y_0;
            this.radius = radius;
            x_1 = this.x_0 + this.radius;
            y_1 = this.y_0;
        }


        //task_1
        public double x_0, y_0, x_1, y_1;




        private double radius;
        public double length()
        {
            set_radius();
            return (Math.Round((2 * radius * Math.PI), 4));
        }
        private void set_radius()
        {
            radius = Math.Sqrt(Math.Pow((x_1 - x_0), 2) + Math.Pow((y_1 - y_0), 2));
        }
        public double get_radius()
        {
            return radius;
        }

        //task_2
        public void change_start()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            x_0 = random.Next(-99, 99);
            y_0 = random.Next(-99, 99);
            x_1 = x_0 + radius;
            y_1 = y_0;
        }

        //task_4
        public double denght(Circle first, Circle second)
        {
            double _x_0 = first.x_0;
            double _y_0 = first.y_0;
            double _x_1 = second.x_0;
            double _y_1 = second.y_0;
            return Math.Sqrt(Math.Pow((_x_1 - _x_0), 2) + Math.Pow((_y_1 - _y_0), 2));
        }

        //task_5
        public bool inter(Circle first, Circle second)
        {
            const double eps = 1e-9;
            double den = first.denght(first, second);
            double r1 = first.get_radius();
            double r2 = second.get_radius();

            return Math.Abs(den - (r1 + r2)) <= eps || Math.Abs(den - Math.Abs(r1 - r2)) <= eps;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите x0: ");
            double X_0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y0: ");
            double Y_0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус: ");
            double RAD_0 = Convert.ToDouble(Console.ReadLine());
            if (RAD_0 <= 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Радиус должен быть > 0");
                Console.ResetColor();
                return;
            }
            Circle circle_1 = new Circle(X_0, Y_0, RAD_0);

            Console.WriteLine();
            Console.WriteLine("x0 = " + circle_1.x_0 + " y0 = " + circle_1.y_0);
            Console.WriteLine("x1 = " + circle_1.x_1 + " y1 = " + circle_1.y_1);
            Console.WriteLine("Длина окружности = " + circle_1.length());
            Console.WriteLine("Радиус окружности = " + circle_1.get_radius());
            Console.WriteLine();

            Console.WriteLine("Введите X1: ");
            double X_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y1: ");
            double Y_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус: ");
            double RAD_1 = Convert.ToDouble(Console.ReadLine());
            if (RAD_1 <= 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Радиус должен быть > 0");
                Console.ResetColor();
                return;
            }
            Circle circle_2 = new Circle(X_1, Y_1, RAD_1);

            Console.WriteLine();
            Console.WriteLine("X0 = " + circle_2.x_0 + " Y0 = " + circle_2.y_0);
            Console.WriteLine("X1 = " + circle_2.x_1 + " Y1 = " + circle_2.y_1);
            Console.WriteLine("Длина окружности = " + circle_2.length());
            Console.WriteLine("Радиус окружности = " + circle_2.get_radius());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Расстояние между окружностями = " + circle_1.denght(circle_1, circle_2));
            Console.WriteLine("Касаются ли окружности: " + circle_1.inter(circle_1, circle_2));
            Console.ResetColor();
            Console.WriteLine();

            //task_2
            circle_1.change_start();

            Console.WriteLine();
            Console.WriteLine("x0 = " + circle_1.x_0 + " y0 = " + circle_1.y_0);
            Console.WriteLine("x1 = " + circle_1.x_1 + " y1 = " + circle_1.y_1);
            Console.WriteLine("Длина окружности = " + circle_1.length());
            Console.WriteLine("Радиус окружности = " + circle_1.get_radius());
            Console.WriteLine();

            circle_2.change_start();

            Console.WriteLine();
            Console.WriteLine("x0 = " + circle_2.x_0 + " y0 = " + circle_2.y_0);
            Console.WriteLine("x1 = " + circle_2.x_1 + " y1 = " + circle_2.y_1);
            Console.WriteLine("Длина окружности = " + circle_2.length());
            Console.WriteLine("Радиус окружности = " + circle_2.get_radius());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Расстояние между окружностями = " + circle_1.denght(circle_1, circle_2));
            Console.WriteLine("Касаются ли окружности: " + circle_1.inter(circle_1, circle_2));
            Console.ResetColor();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
        }
    }
}