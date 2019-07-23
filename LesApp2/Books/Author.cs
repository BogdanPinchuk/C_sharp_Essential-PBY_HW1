using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Автор
    /// </summary>
    class Author
    {
        /// <summary>
        /// Автор ПІБ
        /// </summary>
        public string AuthorOfBook { get; set; }

        /// <summary>
        /// Виведення автора
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\tAuthor: {AuthorOfBook};");
            Console.ResetColor();
        }
    }
}
