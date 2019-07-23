using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3.Geometry
{
    /// <summary>
    /// Фігура
    /// </summary>
    class Figure
    {
        /// <summary>
        /// Точки фігури
        /// </summary>
        private Point[] points;

#if false
        // даний метод можливо ефективніший, якби була можливість не дозволяти
        // створення екземплярів якщо введено інша кількість елементів
        // але щоб це реалізувати необхідно створювати ще 3 конструктора
        /// <summary>
        /// Конструктор який приймає від 3 до 5 точок
        /// </summary>
        /// <param name="points">Точки фігури</param>
        internal Figure(params Point[] points)
        {
            // перевіряємо чи введена кількість точок в допустимих межах 
            if (points.Length < 3 || 5 > points.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nВведена невірна кількість точок,\n" +
                    " необхідно ввести від 3 до 5!");
                Console.ResetColor();
                return;
            }
            else
            {
                // присвоюємо введену кількість точок і створюємо екземпляр
                this.points = points;
            }
        }
#endif

        // варіант згідно умови
        /// <summary>
        /// Конструктор який приймає 3 точки
        /// </summary>
        /// <param name="point0"></param>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        internal Figure(Point point0, Point point1, Point point2)
        {
            // створюємо масив, буде ефективніший автоматичний перебір точок і розрахунок
            points = new Point[3];

            // заповнюємо даними
            points[0] = point0;
            points[1] = point1;
            points[2] = point2;
        }

        /// <summary>
        /// Конструктор який приймає 4 точки
        /// </summary>
        /// <param name="point0"></param>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <param name="point3"></param>
        internal Figure(Point point0, Point point1, Point point2,
            Point point3)
            : this(point0, point1, point2)
        {
            // створюємо тимчасовий масив на 1 більший
            Point[] temp = new Point[points.Length + 1];
            
            // можна реалізувати декількома варіантами
            // 1. через конкатенацію
            // temp = points.Concat(new Point[] { point3 }).ToArray();
            // 2. через додаавання на перед масиву
            // temp = points.Prepend(point3).ToArray()
            // 3. через додавання в кінець масиву
            temp = points.Append(point3).ToArray();

            // перестворюємо головний масив і заносимо дані з тимчасового масиву
            points = new Point[temp.Length];
            points = temp;
        }

        /// <summary>
        /// Конструктор який приймає 5 точок
        /// </summary>
        /// <param name="point0"></param>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <param name="point3"></param>
        /// <param name="point4"></param>
        internal Figure(Point point0, Point point1, Point point2,
            Point point3, Point point4)
            :this(point0, point1, point2, point3)
        {
            // аналогічно методу з 4-ма вхідними даними робимо реалізацію

            // створюємо тимчасовий масив на 1 більший
            Point[] temp = new Point[points.Length + 1];

            // 3. через додавання в кінець масиву
            temp = points.Append(point4).ToArray();

            // перестворюємо головний масив і заносимо дані з тимчасового масиву
            points = new Point[temp.Length];
            points = temp;
        }

        /// <summary>
        /// Довжина сторони фігури, 
        /// назви змінних згідно умови - з великих літер
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        private double LengthSide(Point A, Point B)
        {
            // зразу розраховуємо відстань між двома точками
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        /// <summary>
        /// Розрахунок периметра прямокутника
        /// </summary>
        internal void PerimeterCalculator()
        {
            // змінна для переиметру, зразу можна присвоїти
            // відстань між крайніми точками масиву
            double perim = LengthSide(points.First(), points.Last());

            // розрахунок інших сторін
            for (int i = 0; i < points.Length - 1; i++)
            {
                perim += LengthSide(points[i], points[i + 1]);
            }

            // назва багатокутника
            Console.WriteLine($"\n\tФігура: {points.Length}-кутник;");
            Console.WriteLine($"\tПериметр: {perim:N2};");
        }

    }
}
