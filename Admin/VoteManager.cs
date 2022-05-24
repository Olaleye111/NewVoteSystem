using System;
using VoteSystem.Model;
using VoteSystem.Admin;
using VoteSystem.Menu;
using System.Collections.Generic;

namespace VoteSystem.Admin
{
    public class VoteManager
    {
        //RegisterMenu Menu = new RegisterMenu();
        VotingOfficial votingOfficial = new VotingOfficial();
        public int VoteCount = 0;
        public static List<Vote> Votes = new List<Vote>();
        public void Vote()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Welcome to to your voting page");
            Console.WriteLine("==============================");
            Console.WriteLine();
            Console.WriteLine();
            //Console.Write("Enter Your matric number : ");
            //string matric = Console.ReadLine();

            Console.Write("Enter 1. to vote for president\nEnter 2. to vote for Sports Director\nEnter 3. to vote for treasurer\nEnter 4. to go back to Menu");
            string position = Console.ReadLine();
            if(position == "1")
            {
                position = "PRESIDENT";
            }
            else if(position == "2")
            {
                position = "SPORT DIRECTOR";
            }
            else if(position == "3")
            {
                position = "TREASURER";
            }
            /*else if(position == "4")
            {
                Menu.PrintMenu();
            }*/
            else
            {
                Console.WriteLine("Invalid input");
                Vote();
            }
            votingOfficial.GetContestantByPosition(position);

            Console.WriteLine("From the list Above, Enter the Matric number of the candidate you want to vote for");
            string matric = Console.ReadLine();

            string contestantName = votingOfficial.GetContestantByMatric(matric);
            Console.WriteLine($"Kindly confirm you want to vote for {contestantName} as {position}\nEnter 1. to continue\nEnter 2. to go back");
            int choose;
            while(int.TryParse(Console.ReadLine(), out choose) && choose < 1 || choose > 2)
            {
                Console.WriteLine("invalid input\nTry again...");
            }
            switch(choose)
            {
                case 1:
                VoteCount++;
                Vote Voting = new Vote(VoteCount, matric, position, contestantName);
                Votes.Add(Voting);
                break;

                case 2:
                
                break;
            }
        }

        public void LoginVoter()
        {
            Console.Write("Enter Your Email : ");
            string Email = Console.ReadLine();

            Console.Write("Enter Your matric number : ");
            string matric = Console.ReadLine();

            if(votingOfficial.VotersLogin(matric, Email) == true)
            {
                Vote();
            }
            else
            {
                Console.WriteLine("Invalid input\nGo back to Menu and try Again...");
                Console.ReadLine();
                //Menu.PrintMenu();
            }
        }

        
    }
}
