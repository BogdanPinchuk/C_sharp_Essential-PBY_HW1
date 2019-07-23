using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Заголовок
    /// </summary>
    class Title
    {
        /// <summary>
        /// Назва книги
        /// </summary>
        public string TitleOfBook { get; set; }

        /// <summary>
        /// Виведення назви книги
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\tTitle: {TitleOfBook};");
            Console.ResetColor();
        }
    }
}
