using System;
using VoteSystem.Model;
using VoteSystem.Admin;

namespace VoteSystem.Menu
{
    public class RegisterMenu
    {
        VotingOfficial contestants = new VotingOfficial();
        VoteManager VoteManager = new VoteManager();
        
        public void Menu()
        {
            var exit = false;

            while(exit == false)
            {
                Console.Clear();
                PrintMenu();
                int click;
                if(int.TryParse(Console.ReadLine(), out click))
                {
                    switch(click)
                    {
                        case 1:
                        PrintContestantMenu();
                        int click1;
                        if(int.TryParse(Console.ReadLine(), out click1))
                        {
                            switch(click1)
                            {
                                case 1:
                                contestants.RegisterContestant("President".ToUpper());
                                break;

                                case 2:
                                contestants.RegisterContestant("Sport Director".ToUpper());
                                break;

                                case 3:
                                contestants.RegisterContestant("Treasurer".ToUpper());
                                break;

                                case 4:
                                PrintMenu();
                                break;

                                default:
                                Console.WriteLine("Invalid input");
                                break;
                            }
                        }
                        break;

                        case 2:
                        contestants.RegisterVoter();
                        break;

                        case 3:
                        PrintVoterMenu();
                        int click2;
                        int.TryParse(Console.ReadLine(), out click2);
                        switch(click2)
                        {
                            case 1:
                            VoteManager.LoginVoter();
                            break;

                            case 2:
                            PrintMenu();
                            break;
                        }
                        break;

                        case 4:
                        exit = true;
                        break;

                        default:
                        Console.WriteLine("Invalid Input");
                        break;
                    }
                }
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("---Welcome to CLH Voting App---");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter 1. to Register as Contestant");
            Console.WriteLine("Enter 2. to Register as Voter");
            Console.WriteLine("Enter 3. to Vote");
            Console.WriteLine("Enter 4. to Exit");
        }

        private void PrintContestantMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Enter 1. to Register as President");
            Console.WriteLine("Enter 2. to Register as SportDirector");
            Console.WriteLine("Enter 3. to Register as Treasurer");
            Console.WriteLine("Enter 4. to go back to Menu");
        }

        private void PrintVoterMenu()
        {
            Console.WriteLine("Enter 1. to Login");
            Console.WriteLine("Enter 2. to go back to Menu");
        }
    }
}