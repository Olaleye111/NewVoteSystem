using System;
using System.Collections.Generic;
using VoteSystem;

namespace VoteSystem.Model
{
    public class Student
    {
        public int Id{get; set;}

        //public string Name{get; set;}

        public string Matric{get; set;}

        public string Level{get; set;}

        public Student()
        {
        }

        public Student(int id, string matric, string level)
        {
            Id = id;
            //Name = name;
            Matric = matric;
            Level = level;
        }
        
        public static List<Student> Students = new List<Student>()
        {
            new Student(1, "CLH/19/0001", "clh/19/0001"),
            new Student(2, "CLH/19/0002", "clh/19/0002"),
            new Student(3, "CLH/19/0003", "clh/19/0003"),
            new Student(4, "CLH/20/0004", "clh/20/0004"),
            new Student(5, "CLH/20/0005", "clh/20/0005"),
            new Student(6, "CLH/20/0006", "clh/20/0006"),
            new Student(7, "CLH/21/0007", "clh/21/0007"),
            new Student(8, "CLH/21/0008", "clh/21/0008"),
            new Student(9, "CLH/21/0009", "clh/21/0009"),
            new Student(10, "CLH/22/0010", "clh/22/0010"),
            new Student(11, "CLH/22/0011", "clh/22/0011"),
            new Student(12, "CLH/22/0012", "clh/22/0012")
        };

        public bool CheckM(string matric)
        {
            bool check = false;
            foreach(var item in Students)
            {
                if(item.Matric == matric)
                {
                    check = true;
                }
                if(item.Matric.ToLower() == matric)
                {
                    check = true;
                }
            }
            return check;
        }

        public bool CheckL(string level)
        {
            bool check = false;
            foreach(var item in Students)
            {
                if(item.Level == level)
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
