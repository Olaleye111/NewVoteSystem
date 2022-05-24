using System;
using VoteSystem.Model;
using VoteSystem.Admin;
using VoteSystem.Menu;

namespace VoteSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var gf = new Student();
            //var hg = gf.CheckM("CLH/19/0001");
            //Console.WriteLine(hg);

            //var gg = new VotingOfficial();
            //gg.RegisterVoter();
            //gg.RegisterContestant("president");
            //var f = gg.CheckContestantInList("CLH/20/0004");
            //Console.WriteLine(f);
            //gg.GetContestant();

            var gtt = new RegisterMenu();
            gtt.Menu();
        }
    }
}
