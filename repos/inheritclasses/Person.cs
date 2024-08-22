﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritclasses
{
    internal class Person 
    {


        public string firstName { set; get; }
        public string lastName { set; get; }

        public string gender { set; get; }

        public Person(string firstName, string lastName, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
        }
        //POLYMORPHISM
        public void displayDetails()
        {
            Console.WriteLine("FullName : " + this.firstName + " " + this.lastName);
            Console.WriteLine("Gender : " + this.gender);
        }
    }


}
