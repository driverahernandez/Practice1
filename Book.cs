using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Book
    {
        private string title;
        private string author;
        private long isbn;

        public Book(string title, string author, long isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public string getTitle()
        {
            return this.title;
        }
        public string getAuthor()
        {
            return this.author;
        }
        public long getISBN()
        {
            return this.isbn;
        }
       
        public void displayDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Title: " + getTitle());
            Console.WriteLine("Author: " + getAuthor());
            Console.WriteLine("ISBN: " + getISBN());
        }
        public static void compareBooks(Book book1, Book book2)
        {
            Console.WriteLine();
            Console.WriteLine("Comparing '{0}' and '{1}':", book1.getTitle(), book2.getTitle());
            Console.WriteLine((book1.getISBN == book2.getISBN) ? "Books have the same ISBN" : "Books have different ISBN");
        
        }

    }
}
