using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorKrokow
{
    class Farmer
    {
        public int BagsOfFeed;
        public const int FeedMultiplier = 30;

        private int numberOffCows;
        public int NumberOfCows
        {
            get
            {
                return numberOffCows;
            }
            set
            {   numberOffCows = value;
                BagsOfFeed = numberOffCows * FeedMultiplier;
            }
        }
    }
}
