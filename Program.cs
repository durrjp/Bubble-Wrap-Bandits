using System;
using System.Linq;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("Enter the Bank's Difficulty Level(1-100):");
            string BankDifficultyString = Console.ReadLine();
            int BankDifficulty = Int32.Parse(BankDifficultyString);

            Console.WriteLine("Enter Team Name:");
            string TeamName = Console.ReadLine();
            Team UserTeamName = new Team(TeamName);
            


            while (true)
            {
                Console.WriteLine("Enter Accomplice Name:");
                string Name = Console.ReadLine();

                if (Name != "")
                {
                    Console.WriteLine("Enter accomplice skill level (0-100):");
                    string SkillLevel = Console.ReadLine();
                    int SkillLevelInt = Int32.Parse(SkillLevel);

                    Console.WriteLine("Enter accomplice courage factor (0.0-2.0):");
                    string CourageFactor = Console.ReadLine();
                    double CourageFactorDouble = double.Parse(CourageFactor);

                    TeamMember member = new TeamMember(Name, SkillLevelInt, CourageFactorDouble);
                    UserTeamName.AddTeamMember(member);

                    Console.WriteLine($"Associate: {member.Name}, Skill Level: {member.SkillLevel}, Courage Factor: {member.CourageFactor}");
                }
                else
                {
                    break;
                }
            }
            // int TeamCount = UserTeamName.GetTeamCount();
            // Console.WriteLine($"Team Count: {TeamCount}");

            // foreach(TeamMember member in UserTeamName.TeamReport())
            // {
            //     member.TeamMemberReport();
            // }
            Console.WriteLine("How many trial runs?");
            string TrialsToRunString = Console.ReadLine();
            int TrialsToRun = Int32.Parse(TrialsToRunString);
            int TrialsRun = 0;
            Console.WriteLine("Robbery Report:");
            int Successes = 0;
            int Failures = 0;
            while(TrialsToRun > TrialsRun)
            {
                Random LuckLevelForThisParticularHeist = new Random();
                int ActualLevelOfLuckForThisParticularHeist = LuckLevelForThisParticularHeist.Next(-10, 11);

                int FinalResultOfTheBankDifficultyAndLuckLevel = BankDifficulty + ActualLevelOfLuckForThisParticularHeist;
                
                int TotalTeamSkillz = UserTeamName.AddTeamSkillLevel();

                Console.WriteLine($"This team's skillzzzz {TotalTeamSkillz}");
                Console.WriteLine("");
                Console.WriteLine($"This bank's difficulty level {FinalResultOfTheBankDifficultyAndLuckLevel}");
                Console.WriteLine("");

                if (TotalTeamSkillz > FinalResultOfTheBankDifficultyAndLuckLevel)
                {
                    Console.WriteLine("Suck it, bank! We took your moneeeyyyyysss.");
                    Console.WriteLine("------------");
                    Successes++;
                }
                else
                {
                    Console.WriteLine("Cuff us all! Except Bonny-K. She had nothing to do with this.");
                    Console.WriteLine("------------");
                    Failures++;
                }
                TrialsToRun--;
            }
            Console.WriteLine("------------");
            Console.WriteLine($"Successes: {Successes}");
            Console.WriteLine($"Successes rate: {((Successes/TrialsToRun)*100)}%");
            Console.WriteLine($"Failers: {Failures}");
            Console.WriteLine($"Failers rate: {((Failures/TrialsToRun)*100)}%");
        }
    }
}