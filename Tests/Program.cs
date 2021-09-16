using System;

namespace Tests
{
    class Program
    {
        class Book
        {
            public string name { get; set; }
            public int pageCount { get; set; }

            public Book(string name, int pageCount)
            {
                this.name = name;
                this.pageCount = pageCount;
            }

            public void printInfo()
            {
                Console.WriteLine($"Denne bog hedder \"{name}\" og har {pageCount} sider.");
            }
        }

        class Person
        {
            public int age { get; set; }
            public string name { get; set; }
            public int money { get; set; }
            private Book favoriteBook;

            public Person(int age, string name, int money)
            {
                this.age = age;
                this.name = name;
                this.money = money;
            }

            public void setFavoriteBook(Book favoriteBook)
            {
                this.favoriteBook = favoriteBook;
            }

            public void printInfo()
            {
                Console.WriteLine($"Jeg hedder {name}, jeg er {age} år gammel og jeg har {money} kr.-");
            }

            public void printBookInfo()
            {
                if (favoriteBook != null) // Ellers bliver der en fejl, hvis man ikke har sat en favoriteBook
                {
                    favoriteBook.printInfo();
                }
            }
        }

        static void Main(string[] args)
        {
            Book harryPotter = new Book("Harry Potter og de vises sten", 355);
            Person p1 = new Person(56, "Joanne Kathleen Rowling", 670000000);
            p1.setFavoriteBook(harryPotter);
            p1.printInfo();
            p1.printBookInfo();
        }
    }
}
