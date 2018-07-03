using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSLGUI
{
    class Division
    {
        List<Team> Teams;
        List<Team> Ladder;

        public Division(List<Team> teams)
        {
            Teams = teams; 
        }


        public void PopulateDivision()
        {

            List<Team> DivATeams = new List<Team>();
            DivATeams.Add(new Team() { TeamName = "Wantirna" });
            DivATeams.Add(new Team() { TeamName = "Mt Waverley" });
            DivATeams.Add(new Team() { TeamName = "Scoresby" });
            DivATeams.Add(new Team() { TeamName = "Mitcham" });
            DivATeams.Add(new Team() { TeamName = "Ringwood" });
            DivATeams.Add(new Team() { TeamName = "Wonga Park" });
            DivATeams.Add(new Team() { TeamName = "Mt Evelyn" });
            DivATeams.Add(new Team() { TeamName = "Lilydale" });
            DivATeams.Add(new Team() { TeamName = "Belgrave" });
            DivATeams.Add(new Team() { TeamName = "Beaconsfield" });
            DivATeams.Add(new Team() { TeamName = "Murrumbeena" });
            DivATeams.Add(new Team() { TeamName = "Ferntree Gully" });
            DivATeams.Add(new Team() { TeamName = "Oakleigh" });

            List<Team> DivBTeams = new List<Team>();
            DivBTeams.Add(new Team() { TeamName = "Wantirna" });
            DivBTeams.Add(new Team() { TeamName = "Mt Waverley" });
            DivBTeams.Add(new Team() { TeamName = "Scoresby" });
            DivBTeams.Add(new Team() { TeamName = "Mitcham" });
            DivBTeams.Add(new Team() { TeamName = "Ringwood" });
            DivBTeams.Add(new Team() { TeamName = "Wonga Park" });
            DivBTeams.Add(new Team() { TeamName = "Mt Evelyn" });
            DivBTeams.Add(new Team() { TeamName = "Lilydale" });
            DivBTeams.Add(new Team() { TeamName = "Belgrave" });
            DivBTeams.Add(new Team() { TeamName = "Beaconsfield" });
            DivBTeams.Add(new Team() { TeamName = "Murrumbeena" });
            DivBTeams.Add(new Team() { TeamName = "Ferntree Gully" });
            DivBTeams.Add(new Team() { TeamName = "Oakleigh" });

            List<Team> DivCTeams = new List<Team>();
            DivCTeams.Add(new Team() { TeamName = "Wantirna" });
            DivCTeams.Add(new Team() { TeamName = "Mt Waverley" });
            DivCTeams.Add(new Team() { TeamName = "Scoresby" });
            DivCTeams.Add(new Team() { TeamName = "Mitcham" });
            DivCTeams.Add(new Team() { TeamName = "Ringwood" });
            DivCTeams.Add(new Team() { TeamName = "Wonga Park" });
            DivCTeams.Add(new Team() { TeamName = "Mt Evelyn" });
            DivCTeams.Add(new Team() { TeamName = "Lilydale" });
            DivCTeams.Add(new Team() { TeamName = "Belgrave" });
            DivCTeams.Add(new Team() { TeamName = "Beaconsfield" });
            DivCTeams.Add(new Team() { TeamName = "Murrumbeena" });
            DivCTeams.Add(new Team() { TeamName = "Ferntree Gully" });
            DivCTeams.Add(new Team() { TeamName = "Oakleigh" });

            Division DivisionA = new Division(DivATeams);
            Division DivisionB = new Division(DivBTeams);
            Division DivisionC = new Division(DivCTeams);

        }

    }
}
