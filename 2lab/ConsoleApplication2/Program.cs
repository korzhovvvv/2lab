using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        interface IPrint
        {
            void Print();
        }
        abstract class Figure
        {
            public string Type
            { get; protected set; }
            protected double a, b;
            public abstract double Area();
        }
        class Rectangle : Figure, IPrint
        {

            public Rectangle(double a, double b)
            {
                this.a = a;
                this.b = b;
                this.Type = "Прямоугольник";
            }
            public Rectangle(double a)
            {
                this.a = a;
                this.Type = "Квадрат";
            }
            public override string ToString()
            {
                if (this.Type == "Прямоугольник")
                {
                    return this.Type + "\n" + "Длина равна: " + a + "\n" + "Ширина равна:" + b + "\n" + "Площадь равна: " + Area();
                }
                else
                {
                    return this.Type + "\n" + "Длина и ширина равны: " + a + "\n" + "Площадь равна: " + Area();
                }
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Area()
            {
                if (this.Type == "Прямоугольник")
                {
                    return a * b;
                }
                else
                {
                    return a * a;
                }
            }
        }
        class Circle : Figure, IPrint
        {

            public Circle(double a)
            {
                this.a = a;
                this.Type = "Круг";
            }
            public override string ToString()
            {
                return this.Type + "\n" + "Радиус равен: " + a + "\n" + "Площадь равна: " +
                Area();
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Area()
            {
                return 3.14 * a * a;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру длякоторой  вы хотите посчитать площадь");
            Console.WriteLine("Нажмите 1 === Прямоугольник");
            Console.WriteLine("Нажмите 2 === Квадрат");
            Console.WriteLine("Нажмите 3 === Круг");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Введите длину прямоугольника:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ведите ширину прямоугольника:");
                int c = Convert.ToInt32(Console.ReadLine());
                Rectangle rectangle = new Rectangle(b, c);
                rectangle.Print();
                Console.ReadKey();
            }
            else if (n == 2)
            {
                Console.WriteLine("Введите сторону квадрата:");
                int d = Convert.ToInt32(Console.ReadLine());
                Rectangle square = new Rectangle(d);
                square.Print();
                Console.ReadKey();
            }
            else if (n == 3)
            {
                Console.WriteLine("Введите радиус окружности:");
                int a = Convert.ToInt32(Console.ReadLine());
                Circle circle = new Circle(a);
                circle.Print();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка! Неверное число");
                Console.ReadKey();
            }

        }
    }

}