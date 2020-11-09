using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_6
{
    class Book
    {
        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private string bookAuthor;

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private string bookId;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        private string bookType;

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        private int bookCopy;

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        public Book() { }
        public Book(string bookName,string bookAuthor,string bookId,int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookCopy = bookCopy;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Book Name : " + bookName);
            Console.WriteLine("Author Name : " + bookAuthor);
            Console.WriteLine("Book ID : " + bookId);
            Console.WriteLine("Book Type : " + bookType);
            Console.WriteLine("Available Copy : " + bookCopy);
        }
        public void AddBookCopy(int x)
        {
            if(x>=0)
            {
                bookCopy = bookCopy + x;
                Console.WriteLine("Now available copy : " + bookCopy);
            }
        }



    }
}
