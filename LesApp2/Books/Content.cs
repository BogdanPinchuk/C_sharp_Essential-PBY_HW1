using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Вміст
    /// </summary>
    class Content
    {
        /// <summary>
        /// Зміст
        /// </summary>
        public string ContentOfBook { get; set; }

        /// <summary>
        /// Виведення змісту
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\tContent: {ContentOfBook};");
            Console.ResetColor();
        }
    }
}
