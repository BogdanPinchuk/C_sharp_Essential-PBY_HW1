using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3.Geometry
{
    /// <summary>
    /// Точка
    /// </summary>
    class Point
    {
        /// <summary>
        /// координати точки
        /// </summary>
        private int x, y;
        /// <summary>
        /// назва точки
        /// </summary>
        private string name;

        /// <summary>
        /// координата по Ox
        /// </summary>
        public int X
        {
            get { return x; }
        }
        /// <summary>
        /// координата по Oy
        /// </summary>
        public int Y
        {
            get { return y; }
        }
        /// <summary>
        /// назва  точки
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Конструктор, ініціалізація точки
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="name"></param>
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

    }
}
