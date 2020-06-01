using System;
using System.Linq;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("Enter Team Name:");
            string TeamName = Console.ReadLine();
            Team UserTeamName = new Team(TeamName);

            Random LuckLevelForThisParticularHeist = new Random();
            int ActualLevelOfLuckForThisParticularHeist = LuckLevelForThisParticularHeist.Next(-10, 11);
            int BankDifficulty = 100;

            int FinalResultOfTheBankDifficultyAndLuckLevel = BankDifficulty + ActualLevelOfLuckForThisParticularHeist;

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

            int TotalTeamSkillz = UserTeamName.AddTeamSkillLevel();

            Console.WriteLine($"This team's skillzzzz {TotalTeamSkillz}");
            Console.WriteLine("");
            Console.WriteLine($"This bank's difficulty level {FinalResultOfTheBankDifficultyAndLuckLevel}");
            Console.WriteLine("");

            if (TotalTeamSkillz > FinalResultOfTheBankDifficultyAndLuckLevel)
            {
                Console.WriteLine("Suck it, bank! We took your moneeeyyyyysss.");
            }
            else
            {
                Console.WriteLine("Cuff us all! Except Bonny-K. She had nothing to do with this.");
            }
        }

    }
}