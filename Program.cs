using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
            {
            //challenge1();

            //challenge2();

            challenge3();
            

        }
        public static void challenge1()
        {
            // Create a simple console application that calculates the Body Mass Index
            // (BMI) based on user input for weight and height.
            BMI.bmiExercise();
        }
        public static void challenge2()
        {
            // Design a class named Book with properties for title, author, and ISBN.
            List<Book> books = new List<Book>();
            books.Add(new Book("Dracula", "B. Stoker", 9798721052927));
            books.Add(new Book("Frankenstein", "M. Shelley", 9780143131847));
            books.Add(new Book("Picture of Dorian Gray", "O. Wilde", 9780141439570));

            books[0].displayDetails();
            Book.compareBooks(books[0], books[1]);
        }
        public static void challenge3()
        {
            // Write a program that simulates a simple ATM machine.
            double balance = 3000;
            ATM account = new ATM(balance);
            while (true)
            {
                int choice = ATM.displayMenu();
                if (choice == 4)
                    break;
                switch (choice)
                {
                    case 1:
                        account.checkBalance();
                        break;
                    case 2:
                        account.withdraw();
                        break;
                    case 3:
                        account.deposit();
                        break;
                    default:
                        break;
                }
            }
            
        }
  
    }
}



