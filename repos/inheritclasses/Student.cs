﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritclasses;
 internal class Student : Person
{
    public int studentId { get; set; }
    public int marks { get; set; }

    public Student(string firstName, string lastName, string gender, int studentId, int marks) : base(firstName, lastName, gender)
    {
        this.studentId = studentId;
        this.marks = marks;
    }


    //POLYMORPHISM
    public void displayDetails()
    {
        base.displayDetails();
        Console.WriteLine("Student Id :" + this.studentId);
        Console.WriteLine("Student Marks : " + this.marks);
    }
}