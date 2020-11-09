using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_6
{
    class Library
    {
        private string libraryName;

        public string LibraryName
        {
            get { return libraryName; }
            set { libraryName = value; }
        }
        private string libraryAddress;

        public string LibraryAddress
        {
            get { return libraryAddress; }
            set { libraryAddress = value; }
        }
        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        Book[] listOfBook;
        public Library() { }
        public Library(string libraryName , string libraryAddress , int totalBook , int sizeOfArray)
        {
            this.libraryName = libraryName;
            this.libraryAddress = libraryAddress;
            this.totalBook = totalBook;
            listOfBook = new Book[sizeOfArray];
        }
        public void AddNewBooks(params Book[] book)
        {
            foreach(var b in book)
            {
                for(int i = 0; i<listOfBook.Length;i++)
                {
                    if(listOfBook[i]==null)
                    {
                        listOfBook[i] = b;
                        break;
                    }
                }
            }
            totalBook++;
        }

        public void DeleteBook(params Book[] book)
        {
            foreach(var b in book)
            {
                for(int i = 0; i<listOfBook.Length;i++)
                {
                    if(listOfBook[i]==b)
                    {
                        listOfBook[i] = null;
                        break;
                    }
                }
            }
            totalBook--;
        }
        public void AddNewBookCopy(Book book , int copy)
        {
            if(copy>0)
            {
                for (int i = 0; i < listOfBook.Length; i++)
                {
                    if (listOfBook[i] == null)
                    {
                        listOfBook[i] = book;
                        break;
                    }
                }
                totalBook = totalBook + copy;

            }
        }
        public void ShowAllBooks()
        {
            foreach(Book b in listOfBook)
            {
                if(b!=null)
                {
                    b.ShowInfo();
                }
            }
        }


    }
}
