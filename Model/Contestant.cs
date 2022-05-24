using System;
using VoteSystem.Enum;

namespace VoteSystem.Model
{
    public class Contestant:Person
    {
        public LeVel Level{get; set;}
        public GraDe Grade{get; set;}

        public string PositionName{get; set;}

        public Contestant(int id, string firstname, string lastname, GenDer gender, string matric, string email, LeVel level, GraDe grade, string positionname):base(id, firstname, lastname, gender, matric, email)
        {
            Level = level;
            Grade = grade;
            PositionName = positionname;
        }
    }
}