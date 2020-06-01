using System;
using System.Linq;
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

        public int GetTeamCount()
        {
            return _teamList.Count;
        }

        // Constructor Method
        public Team(string TeamName)
        {
            _teamName = TeamName;
        }

        // public List<plan_your_heist.TeamMember> TeamReport()
        // {
        //     return _teamList;
        // }

        public int AddTeamSkillLevel()
        {
            List<int> TeamSkillLevel = _teamList.Select(ass => ass.SkillLevel).ToList();
            return TeamSkillLevel.Sum();
        }
    }
}