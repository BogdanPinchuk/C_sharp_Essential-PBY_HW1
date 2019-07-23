using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesApp3.Geometry;

namespace LesApp3
{
    class Program
    {
        static void Main()
        {
            // підключення Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // 1. трохи не уточнено, чи робити вивід даних із конструктора зразу
            // чи зробить як окремий метод який визивається через екземпляр
            // 2. не було уточнення чи аналізувати розташування точок,  чи є однакові точки,
            // чи вони записані випадково і необхідно їх правильно упорядкувати,
            // тому зігдно ТЗ тобто умови вся відповідальність лежить на користувачеві
            // 3. так як не вказано щоб хтось вводив дані, то просто згенеруємо випадкові
            // точки для підтвердження роботи алгоритму

            #region створення точок
            int[,] points = new int[5, 2];
            string[] name = { "A", "B", "C", "D", "E" };

            // для генерації випадкових точок
            Random rnd = new Random();

            // випадкові числа, (економія часу придумування)
            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    points[i, j] = rnd.Next(sbyte.MinValue, sbyte.MaxValue);
                }
            }

            // створюэмо масив 5 точок
            Point[] pointM = new Point[points.GetLength(0)];

            // заповнюємо даними
            for (int i = 0; i < points.GetLength(0); i++)
            {
                pointM[i] = new Point(points[i, 0], points[i, 1], name[i]);
            }
            #endregion

            #region створення фігур і виведення даних
            // створюємо першу фігуру
            Figure figure = new Figure(pointM[0], pointM[1], pointM[2]);
            // виводимо дані
            figure.PerimeterCalculator();

            // створюємо другу фігуру
            figure = new Figure(pointM[0], pointM[1], pointM[2], pointM[3]);
            // виводимо дані
            figure.PerimeterCalculator();

            // створюємо третю фігуру
            figure = new Figure(pointM[0], pointM[1], pointM[2], pointM[3], pointM[4]);
            // виводимо дані
            figure.PerimeterCalculator();
            #endregion

            // повторення
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
