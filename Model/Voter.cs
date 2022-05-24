using System;
using VoteSystem.Enum;
using VoteSystem.Model;
using VoteSystem.Admin;

namespace VoteSystem.Model
{
    public class Voter:Person
    {
        public Voter(int id, string firstname, string lastname, GenDer gender, string matric, string email):base(id, firstname, lastname, gender, matric, email)
        {
        }
    }
}