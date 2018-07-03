using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSLGUI
{
    public class Round
    {
        public int Season { get; set; }
        public int RoundNumber { get; set; }
        public DateTime RoundDate { get; set; }
        List<Game> games { get; set; }

        public Round(int roundNumber, DateTime roundDate) {
            RoundNumber = roundNumber;
            RoundDate = roundDate;
            List<Game> games = new List<Game>();
        }

        public void PopulateRound(char div, int year)
        {

        }

    }

}
