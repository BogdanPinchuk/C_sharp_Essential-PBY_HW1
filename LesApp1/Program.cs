using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            #region введення даних
            Console.Write("\tВведіть 1-шу сторону прямокутника: ");
            bool error = double.TryParse(Console.ReadLine(), out double side1);
            // прийдеться згыдно умови робити зразу тут перевірку, так як необхідно занести дані прямо в екземпляр,
            // хоча спочатку реалізована була перевірка в самому об'єкті
            // аналіз чи можна далі продовжувати 
            if (!error || side1 <= 0)
            {
                AnaliseOfInputNumber(false);
            }

            Console.Write("\tВведіть 2-гу сторону прямокутника: ");
            error = double.TryParse(Console.ReadLine(), out double side2);
            // аналіз чи можна далі продовжувати 
            if (!error || side2 <= 0)
            {
                AnaliseOfInputNumber(false);
            }
            #endregion

            // Створюємо прямокутник
            Rectangle rect = new Rectangle(side1, side2);

            // Виводимо дані:
            Console.WriteLine("\nПерший варіант виводу - через властивості:");
            Console.WriteLine($"\tПлоща прямокутника: S = {rect.Area:N2}");
            Console.WriteLine($"\tПериметр прямокутника: P = {rect.Perimeter:N2}");

            Console.WriteLine("\nДругий варіант виводу - через вбудований метод:");
            rect.Show();

            // повторення
            DoExitOrRepeat();
        }

        /// <summary>
        /// Умова коли невірно введені дані
        /// </summary>
        /// <param name="res"></param>
        static void AnaliseOfInputNumber(bool res)
        {
            if (!res)
            {
                Console.WriteLine("\nНевірно введені дані!");
                DoExitOrRepeat();
            }
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
