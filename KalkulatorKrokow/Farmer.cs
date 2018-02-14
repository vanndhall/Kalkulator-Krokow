using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorKrokow
{
    class Farmer
    {
        //hermetyzacja BagsOfFeed  nie mozna zmodyfikowac,tylko odczyt - ide zrobilo to automatycznie za pomoca wpisania: prop i dwukrotnie nacisniecie TAB -kwestia zmiany nazwy domyślnej
        public int BagsOfFeed { get; private set; }
        public const int FeedMultiplier = 30;

        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {   numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}
