using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSLGUI
{
    class Season
    {
        int NumRounds { get; set; }
        public List<Round> AllRounds { get; set; }
        public DateTime StartDate { get; set; }

        public Season(int rounds, DateTime startDate)
        {
            NumRounds = rounds;
            StartDate = startDate;

            List<Round> listRounds = new List<Round>();
            for (int i = 0; i < rounds; i++)
            {
                Round round = new Round(i+1, startDate);
                listRounds.Add(round);
                startDate = startDate.AddDays(7);
            }

            AllRounds = listRounds;

        }
    }
}
