using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // підключення юнікоду
            Console.OutputEncoding = Encoding.Unicode;

            // Створюємо екземпляр класу адреси
            Address address = new Address();

            // Введення даних, 
            #region базове введення
            address.Index = 03056;
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Viborzka";
            address.House = 1;
            address.Apartment = 107;
            #endregion

            // виведення даних
            Console.WriteLine("Виведення інформації:\n");
            Console.WriteLine("Повне детальне:");
            address.Show();

            Console.WriteLine("\nСкорочене:\n");
            address.ShowShort();

            Console.WriteLine("\nТестування перегрузок:\n");  // слабка ссилка
            #region тестування перегрузок
            Console.WriteLine("Повне детальне:");
            new Address().Show("Ukraine", "Kyiv", "Prosp. Peremohy", 37, 1, 03056);

            Console.WriteLine("\nСкорочене:\n");
            new Address().ShowShort("Ukraine", "Kyiv", "Prosp. Peremohy", 37, 1, 03056);
            #endregion

            // delay
            Console.ReadKey(true);
        }
    }
}
