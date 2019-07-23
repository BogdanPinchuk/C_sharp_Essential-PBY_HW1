using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    /// <summary>
    /// Прямокутник
    /// </summary>
    class Rectangle
    {
        /// <summary>
        /// Довжини сторін прямокутника
        /// </summary>
        private double side1,
            side2;
        /// <summary>
        /// Параметри прямокутника
        /// </summary>
        private double area,
            perimeter;

        /// <summary>
        /// 1-а сторона
        /// </summary>
        public double Side1
        {
            get { return side1; }
            set
            {
                side1 = AnaliseSide(value);
                AreaCalculator();
                PerimeterCalculator();
            }
        }
        /// <summary>
        /// 2-а сторона
        /// </summary>
        public double Side2
        {
            get { return side2; }
            set
            {
                side2 = AnaliseSide(value);
                AreaCalculator();
                PerimeterCalculator();
            }
        }

        /// <summary>
        /// Площа прямокутника
        /// </summary>
        public double Area
        {
            get { return area; }
        }

        /// <summary>
        /// Периметр прямокутника
        /// </summary>
        public double Perimeter
        {
            get { return perimeter; }
        }

        /// <summary>
        /// Ініціалізація сторін прямокутника
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        /// <summary>
        /// Розрахунок площі
        /// </summary>
        /// <returns></returns>
        public void AreaCalculator()
        {
            area = side1 * side2;
        }

        /// <summary>
        /// Розрахунок площі, без зміни значень полів
        /// </summary>
        /// <returns></returns>
        public double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;
        }

        /// <summary>
        /// Розрахунок периметра
        /// </summary>
        /// <returns></returns>
        public void PerimeterCalculator()
        {
            perimeter = 2 * (side1 * side2);
        }

        /// <summary>
        /// Розрахунок периметра, без зміни значень полів
        /// </summary>
        /// <returns></returns>
        public double PerimeterCalculator(double side1, double side2)
        {
            return 2 * (side1 * side2);
        }

        /// <summary>
        /// Аналіз введених даних згідно параметрів фігури
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        private double AnaliseSide(double side)
        {
            if (side <= 0)
            {
                Console.WriteLine("Сторона фігури не може бути меншою або рівною нулю!");
                return default;     // вертаємо стандартне значення
            }else
            {
                return side;        // вертаємо значення сторони
            }
        }

        /// <summary>
        /// Вивід результатів
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"\tПлоща прямокутника: S = {Area:N2}");
            Console.WriteLine($"\tПериметр прямокутника: P = {Perimeter:N2}");
        }

        /// <summary>
        /// Вивід результатів
        /// </summary>
        public void Show(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
            Show();
        }

    }
}
