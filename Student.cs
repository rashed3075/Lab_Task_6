﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_6
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private int borrowDate;

        public int BorrowDate
        {
            get { return borrowDate; }
            set { borrowDate = value; }
        }


        public Student() { }
        public Student(string name , string id , string department , float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;

        }
        Book[] book;
        public void ShowInfo()
        {
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Student ID : " + Id);
            Console.WriteLine("Student Department : " + Department);
            Console.WriteLine("Student CGPA : " + Cgpa);
        }

        public void BorrowBookInfo()
        {
            string currentDate = DateTime.Now.Date.ToString();

        }

    }
}
