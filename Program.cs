using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
            {
            // uncomment any of the methods to run the corresponding code
            // for each of the challenges.

            primitiveTypes();

            //nonPrimitiveTypes();

            //controlFlow();

            //arraysAndLists();

            //workingWithDates();

            //workingWithText();

            //workingWithFiles();
        }

        public static void primitiveTypes()
        {
            // Create a simple console application that calculates the Body Mass Index
            // (BMI) based on user input for weight and height.
            BMI.bmiExercise();
        }
        public static void nonPrimitiveTypes()
        {
            // Design a class named Book with properties for title, author, and ISBN.
            List<Book> books = new List<Book>();
            books.Add(new Book("Dracula", "B. Stoker", 9798721052927));
            books.Add(new Book("Frankenstein", "M. Shelley", 9780143131847));
            books.Add(new Book("Picture of Dorian Gray", "O. Wilde", 9780141439570));

            books[0].displayDetails();
            Book.compareBooks(books[1], books[2]);
        }
        public static void controlFlow()
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
        public static void arraysAndLists()
        {
            //Create a console application that manages a list of student grades.
            Class students = new Class();
            students.inputGrades();
            var maxGrade = students.getMaxGrade();
            var minGrade = students.getMinGrade();
            var average = students.calculateAverage();

            Console.WriteLine("Max Grade: {0}\nMin Grade: {1}\nAverage: {2}", maxGrade, minGrade, average);

        }
        public static void workingWithDates()
        {
            //Develop a program that calculates the number of days between two dates.
            Console.WriteLine("Enter dates with format MM/DD/YYYY");
            Console.WriteLine("Enter date of start:");
            var start = Console.ReadLine();
            Console.WriteLine("Enter date of end:");
            var end = Console.ReadLine();
            var startDate = DateTime.Parse(start);
            var endDate = DateTime.Parse(end);
            Console.WriteLine("Difference in days: {0}", (endDate-startDate).TotalDays);
        }
        public static void workingWithText()
        {
            //Write a program that processes a block of text to count the number of
            //words, sentences, and paragraphs.
            Text text = new Text();
            text.writeText();
            var parAmount = text.getParagraphCount();
            var sentAmount = text.getSentenceCount();
            var wordAmount = text.getWordCount();

            Console.WriteLine("Amount of paragraphs: {0}\nAmount of Sentences: {1}\nAmount of words: {2}", parAmount, sentAmount, wordAmount);

        }
        public static void workingWithFiles()
        {
            // Create a program that reads a text file containing a list of names and
            // writes a new file with the names sorted alphabetically.
            
            var originPath = ".\\names.txt";
            var copyPath = "..\\..\\..\\namesAlphabetical.txt";
            //in VisualStudio current directory while executing is "\Practice1\bin\Debug\net8.0"
            //but to see the resulting file in the Solution Explorer it has to be saved in "\Practice1"
            var names = File.ReadAllLines(originPath);
            Array.Sort(names);
            File.WriteAllLines(copyPath, names);
            Console.WriteLine("Finished. You can find the list of sorted names in the file \'namesAlphabetical.txt\'");
        }
    }
}



