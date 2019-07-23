using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Створення книги і введення даних
            Book book1 = new Book()
            {
                Title = "C#. Советы программистам",
                Author = "Климов Александр Петрович",
                Content = "Использование стандартных алгоритмов,\n" +
                "использование особенностей интегрированной среды разработки IDE,\n" +
                "работа с формами, элементами управления,\n" +
                "использование технологий WMI, WSH,\n" +
                "вызов системных функций Windows API"
            };

            Book book2 = new Book()
            {
                Title = "Practical C# Charts and Graphics",
                Author = "Jack Xu",
                Content = "Advanced Chart and Graphics Programming\n" +
                "for Real - World.NET Applications"
            };

            // Виведення даних
            book1.Show();
            book2.Show();

            // delay
            Console.ReadKey(true);
        }
    }
}
