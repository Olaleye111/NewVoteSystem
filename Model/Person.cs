using System;
using VoteSystem.Enum;
using VoteSystem;

namespace VoteSystem.Model
{
    public class Person
    {
        public int Id{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public GenDer Gender{get; set;}
        public string Matric{get; set;}
        public string Email{get; set;}

        public Person(int id, string firstname, string lastname, GenDer gender, string matric, string email)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            Matric = matric;
            Email = email;
        }
    }
}