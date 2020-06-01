using System.Collections.Generic;

namespace plan_your_heist
{
    class Team
    {
        // Private Fields
        private string _teamName;

        private List<TeamMember> _teamList = new List<TeamMember>();

        // Methods
        public void AddTeamMember(TeamMember accomplice)
        {
            _teamList.Add(accomplice);
        }

        // Constructor Method
        public Team(string TeamName)
        {
            _teamName = TeamName;
        }
    }
}