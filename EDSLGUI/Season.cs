using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSLGUI
{
    public class Season
    {
        public List<DateTime> Blackout { get; set; }
        public int NumRounds { get; set; }
        public List<Round> AllRounds { get; set; }
        public DateTime StartDate { get; set; }

        public Season(int rounds, DateTime startDate)
        {

            NumRounds = rounds;
            StartDate = startDate;
            Blackout = new List<DateTime>();

            List<Round> listRounds = new List<Round>();
            for (int i = 0; i < rounds; i++)
            {
                Round round = new Round(i+1, startDate);
                listRounds.Add(round);
                startDate = startDate.AddDays(7);
            }

            AllRounds = listRounds;
        }

        public Season RescheduleApplyBlackout(Season pseason, DateTime blackout)
        {
            Season season = new Season(pseason.AllRounds.Count, pseason.StartDate);
            season.Blackout = pseason.Blackout;
            season.Blackout.Add(blackout);
            List<Round> rescheduledRounds = new List<Round>();
            DateTime date = pseason.StartDate;

            while (rescheduledRounds.Count < AllRounds.Count)
            {
                Round round = new Round(rescheduledRounds.Count + 1, date);
                if (season.Blackout.Contains(date))
                {
                    date = date.AddDays(7);
                }
                else
                {
                    rescheduledRounds.Add(round);
                    date = date.AddDays(7);
                }
            }

            season.AllRounds = rescheduledRounds;
            return season;
        }

    }
}
