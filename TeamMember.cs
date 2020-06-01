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
    }

}