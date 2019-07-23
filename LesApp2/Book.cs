using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Книга
    /// </summary>
    class Book
    {
        private Title title = new Title();
        private Author author = new Author();
        private Content content = new Content();

        /// <summary>
        /// Додавання заголовку
        /// </summary>
        public string Title
        {
            get { return title.TitleOfBook; }
            set { title.TitleOfBook = value; }
        }
        /// <summary>
        /// Додавання автора
        /// </summary>
        public string Author
        {
            get { return author.AuthorOfBook; }
            set { author.AuthorOfBook = value; }
        }
        /// <summary>
        /// Додавання змісту
        /// </summary>
        public string Content
        {
            get { return content.ContentOfBook; }
            set { content.ContentOfBook = value; }
        }

        /// <summary>
        /// Виведення даних про книгу
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Book:");
            title.Show();
            author.Show();
            content.Show();
            Console.WriteLine();
        }

    }
}
