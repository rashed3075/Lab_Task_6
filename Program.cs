using System;

namespace Lab_Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Rashed", "19-39431-1", "CSE", 3.50f);
            s1.ShowInfo();
            Console.WriteLine("-----------");
            Account a1 = new Account("Rabby", "XX-XX", 0);
            a1.Deposit(10000);
            Console.WriteLine("-----------");
            Book b1 = new Book("Chemistry", "XXXXX", "1101", 5);
            Book b2 = new Book("Physics", "YYYY", "1102", 10);
            b1.ShowInfo();
            Console.WriteLine("-----------");
            Library l1 = new Library("Jonota Library","SwgunBagicha",5,100);
            l1.AddNewBooks(b1, b2);
            l1.DeleteBook(b1);
            l1.ShowAllBooks();
        }
    }
}
