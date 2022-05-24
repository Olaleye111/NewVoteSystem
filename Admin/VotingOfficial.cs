using System;
using System.Collections.Generic;
using VoteSystem.Enum;
using VoteSystem.Model;
using VoteSystem.Admin;

namespace VoteSystem.Admin
{
    public class VotingOfficial
    {
        public static int NumOfVoters = 0;

        public static List<Voter> Voters = new List<Voter>();

        public void RegisterVoter()
        {
            Console.Write("Enter your firstname : ");
            string fname = Console.ReadLine();

            Console.Write("Enter your last name : ");
            string lname = Console.ReadLine();

            Console.Write("What is your Gender\nEnter 1 for Male and 2 for female : ");
            int gender;
            while(int.TryParse(Console.ReadLine(), out gender) && gender < 1 || gender > 2)
            {
                Console.WriteLine("Invalid input\nTry Again...");
            }

            Console.Write("Enter your e-mail : ");
            string email = Console.ReadLine();

            Console.Write("Enter your matric Number : ");
            //int count = 0;
            string matric = Console.ReadLine();
            
            if(CheckMatric(matric) == false)
            {
                Console.WriteLine("Due to the matric number you entered\nYou are not a student, so therefore you are not eligible to vote");
            }
            else
            {
                NumOfVoters++;

                var EligibleVoters = new Voter(NumOfVoters, fname, lname, (GenDer)gender, matric, email);

                Voters.Add(EligibleVoters);

                Console.WriteLine("You have succesfully register as a voter");

                Console.WriteLine("Enter any key to go to Menu");
                Console.ReadLine();
            }
        }

        public bool VotersLogin(string matric, string email)
        {
            bool check = false;
            foreach(var item in Voters)
            {
                if(item.Matric == matric && item.Email == email)
                {
                    check = true;
                }
            }
            return check;
        }

        public bool CheckMatric(string matric)
        {
            var mat = new Student();
            var check = mat.CheckM(matric);
            return check;
        }

        int numOfContestants;
        public static List<Contestant> Contest = new List<Contestant>();

        public void RegisterContestant(string position)
        {
            string positioN = position;
            
            Console.Write("Enter your firstname : ");
            string fname = Console.ReadLine();

            Console.Write("Enter your last name : ");
            string lname = Console.ReadLine();

            Console.Write("What is your Gender\nEnter 1 for Male and 2 for female : ");
            int gender;
            while(int.TryParse(Console.ReadLine(), out gender) && gender < 1 || gender > 2)
            {
                Console.WriteLine("Invalid input\nTry Again...");
            }

            Console.Write("Enter your e-mail : ");
            string email = Console.ReadLine();

            Console.Write("Enter your matric Number : ");
            string matric = Console.ReadLine();

            Console.WriteLine("Enter 1. if youre in 100 Level\nEnter 2. if youre in 200 level\nEnter 3. if youre in 300 level\nEnter 4. if youre in 400 level");
            int level;
            while(int.TryParse(Console.ReadLine(), out level) && level < 1 || level > 4)
            {
                Console.WriteLine("Invalid input\nTry Again...");
            }
            

            Console.Write("Enter 1. if your grade is between 3.50 - 4.00\nEnter 2. if your grade is between 3.00 - 3.49\nEnter 3. if your grade is between 2.50 - 2.99\nEnter 4. if your grade is between 2.00 - 2.49\n");
            int grade;
            while(int.TryParse(Console.ReadLine(), out grade) && grade < 1 || grade > 4)
            {
                Console.WriteLine("Invalid input\nTry Again...");
            }

            if(CheckMatric(matric) == false)
            {
                Console.WriteLine("Due to the matric number you entered\nYou are not a student, so therefore you are not eligible to vote");
                Console.ReadLine();
            }
            else if(level != 4)
            {
                Console.WriteLine("Due to your current level. Youre not elegible to be a contestant\nKindly register as a voter");
                Console.ReadLine();
            }
            else if(grade != 1)
            {
                Console.WriteLine("Due to your grade. Youre not elegible to be a contestant\nKindly register as a voter");
                Console.ReadLine();
            }
            else if(CheckContestantInList(matric) == true)
            {
                Console.WriteLine("You are already a registered contestant");
                Console.ReadLine();
            }
            else
            {
               numOfContestants++;

               Contestant EligibleVoters = new Contestant(NumOfVoters, fname, lname, (GenDer)gender, matric, email, (LeVel)level, (GraDe)grade, position);

               Contest.Add(EligibleVoters);

               Console.WriteLine("You have succesfully registered as a " + position);

               Console.WriteLine("Enter any key to exit");
               Console.ReadLine();
            }
        }

        public bool CheckLevel(string level)
        {
            var ch = new Student();
            var check = ch.CheckL(level);
            return check;
        }
        
        /*public void AvailableContestant(string position)
        {
            foreach (var item in Contest)
            {
                if (item.PositionName == "President" && position == "President".ToLower())
                {
                    Console.WriteLine($" {item.FirstName} {item.LastName}");
                }
                else if (item.PositionName == "Sport Director" && position == "Sport Director".ToLower())
                {
                    Console.WriteLine($" {item.FirstName} {item.LastName}");
                }
                else if (item.PositionName == "Treasurer" && position == "Treasurer".ToLower())
                {
                    Console.WriteLine($" {item.FirstName} {item.LastName}");
                }
            }
        } */

        public bool CheckContestantInList(string matriculation)
        {
            bool check = false;
            foreach(var item in Contest)
            {
                if(item.Matric.ToUpper() == matriculation.ToUpper())
                {
                    check = true;
                }
                check = false;
            }
            return check;
        }

        public void GetContestantByPosition(string position)
        {
            foreach(var item in Contest)
            {
                if(item.PositionName.ToUpper() == position.ToUpper())
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("No contestant Available for this position");
        }

        public string GetContestantByMatric(string matric)
        {
            foreach(var item in Contest)
            {
                if(item.Matric.ToUpper() == matric.ToUpper())
                {
                    return item.FirstName +" "+ item.LastName;
                }
            }
            return "invalid matric";
        }
    }
}