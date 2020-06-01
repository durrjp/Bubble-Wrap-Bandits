using System;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Enter accomplice name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter accomplice skill level 0-100.");
            string SkillLevel = Console.ReadLine();
            int SkillLevelInt = Int32.Parse(SkillLevel);
            Console.WriteLine("Enter accomplice courage factor 0.0-2.0");
            string CourageFactor = Console.ReadLine();
            double CourageFactorDouble = double.Parse(CourageFactor);
            TeamMember memberOne = new TeamMember(Name, SkillLevelInt, CourageFactorDouble);
            Console.WriteLine($"Associate: {memberOne.Name}, Skill Level: {memberOne.SkillLevel}, Courage Factor: {memberOne.CourageFactor}");

        }

    }
}