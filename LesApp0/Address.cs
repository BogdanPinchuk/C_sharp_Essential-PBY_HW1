using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    /// <summary>
    /// Адреса
    /// </summary>
    class Address
    {
        /// <summary>
        /// Індекс
        /// </summary>
        private int index;
        /// <summary>
        /// Країна
        /// </summary>
        private string country;
        /// <summary>
        /// Місто
        /// </summary>
        private string city;
        /// <summary>
        /// Вулиця
        /// </summary>
        private string street;
        /// <summary>
        /// Дім, номер
        /// </summary>
        private int house;
        /// <summary>
        /// Квартира, номер
        /// </summary>
        private int apartment;

        /// <summary>
        /// Індекс
        /// </summary>
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        /// <summary>
        /// Країна
        /// </summary>
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        /// <summary>
        /// Місто
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        /// <summary>
        /// Вулиця
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        /// <summary>
        /// Номер дому
        /// </summary>
        public int House
        {
            get { return house; }
            set { house = value; }
        }
        /// <summary>
        /// Номер квартири
        /// </summary>
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        /// <summary>
        /// Виведення інформації, детальне
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"\n\tCountry: {Country};");
            Console.WriteLine($"\tCity: {City};");
            Console.WriteLine($"\tStreet: {Street};");
            Console.WriteLine($"\tHouse: {House};");
            Console.WriteLine($"\tApartment: {Apartment};");
            Console.WriteLine($"\tIndex: {Index:D5};");
        }

        /// <summary>
        /// Виведення інформації, коротке
        /// </summary>
        public void ShowShort()
        {
            Console.WriteLine($"\t{House} {Street} St, Apt {Apartment}, {City}, {Country}, {Index:D5}");
        }

        /// <summary>
        /// Виведення інформації, детальне
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="house"></param>
        /// <param name="apartment"></param>
        /// <param name="index"></param>
        public void Show(string country,
            string city,
            string street,
            int house,
            int apartment,
            int index)
        {
            // Зберігаємо дані
            SaveInfo(country, city, street, house, apartment, index);

            // відображаємо
            Show();
        }

        /// <summary>
        /// Виведення інформації, коротке
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="house"></param>
        /// <param name="apartment"></param>
        /// <param name="index"></param>
        public void ShowShort(string country,
            string city,
            string street,
            int house,
            int apartment,
            int index)
        {
            // Зберігаємо дані
            SaveInfo(country, city, street, house, apartment, index);

            // відображаємо
            ShowShort();
        }

        /// <summary>
        /// Збереження інформації
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="house"></param>
        /// <param name="apartment"></param>
        /// <param name="index"></param>
        private void SaveInfo(string country,
            string city,
            string street,
            int house,
            int apartment,
            int index)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
            this.index = index;
        }

    }
}
