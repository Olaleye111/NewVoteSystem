using System;

namespace VoteSystem.Model
{
    public class Vote
    {
        public int Id {get; set;}
        public string MatriculationNumber {get; set;}
        public string PositionName {get; set;}
        public  string ContestantName {get; set;}

        public Vote(int id, string matriculation, string positionName, string contestantName)
        {
            Id = id;
            MatriculationNumber = matriculation;
            PositionName = positionName;
            ContestantName = contestantName;
        }
    }
}