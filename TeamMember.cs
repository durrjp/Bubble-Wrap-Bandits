using System;

namespace plan_your_heist
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        public TeamMember(string newMember, int skillLevel, double courage)
        {
            Name = newMember;
            SkillLevel = skillLevel;
            CourageFactor = courage;
        }

        // public void TeamMemberReport()
        // {
        //     Console.WriteLine($"---------------------------------");
        //     Console.WriteLine($"Accomplice Name: {this.Name}");
        //     Console.WriteLine($"Skill Level: {this.SkillLevel}");
        //     Console.WriteLine($"Courage Factor: {this.CourageFactor}");
        // }
    }

}