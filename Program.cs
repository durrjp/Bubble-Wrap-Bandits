using System;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("Enter Team Name.");
            string TeamName = Console.ReadLine();
            Team UserTeamName = new Team(TeamName);

            while (true)
            {
                Console.WriteLine("Enter accomplice name");
                string Name = Console.ReadLine();

                if (Name != "")
                {
                    Console.WriteLine("Enter accomplice skill level 0-100.");
                    string SkillLevel = Console.ReadLine();
                    int SkillLevelInt = Int32.Parse(SkillLevel);

                    Console.WriteLine("Enter accomplice courage factor 0.0-2.0");
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
            int TeamCount = UserTeamName.GetTeamCount();
            Console.WriteLine($"{TeamCount}");

        }

    }
}