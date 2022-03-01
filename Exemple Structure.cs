using System;

namespace ExempleStructure
{
    class Program
    {
        struct Book 
        {
            public string nameBook;
            public string publishingCompany;
            public string athour;
            public int pages;
        }

        static void Main(string[] args)
        {
            Book book1;
            Console.WriteLine("======Book 01=======");

            Console.WriteLine("Whats the name's book?");
            book1.nameBook = Console.ReadLine();

            Console.WriteLine("Whats the name's Publishing Company?");
            book1.publishingCompany = Console.ReadLine();

            Console.WriteLine("How's the athour?");
            book1.athour = Console.ReadLine();

            Console.WriteLine("How many pages there it?");
            book1.pages = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------//-------------------------");
           
            Book book2;
            Console.WriteLine("======Book 02=======");

            Console.WriteLine("Whats the name's book?");
            book2.nameBook = Console.ReadLine();

            Console.WriteLine("Whats the name's Publishing Company?");
            book2.publishingCompany = Console.ReadLine();

            Console.WriteLine("How's the athour?");
            book2.athour = Console.ReadLine();

            Console.WriteLine("How many pages there it?");
            book2.pages = int.Parse(Console.ReadLine());

        }
    }
}
