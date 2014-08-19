using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Avat.Wrappers;

namespace Avat.Components
{
    public class BiznisReport
    {
        public int PocVyst = 0;
        public int PocPrij = 0;
        public decimal SumaVyst = 0;
        public decimal SumaPrij = 0;
        public decimal Balance = 0;   // bilancia.. suma vyst - suma prijatych
        public decimal DaneVyst = 0;
        public decimal DanePrij = 0;
        public int PocetBlacklistOdb = 0;
        public int PocetBlacklistDod = 0;

        List<A1Wrapper> topOdberatel;
        internal List<A1Wrapper> TopOdberatel
        {
            get
            {
                return topOdberatel;
            }

            set
            {
                topOdberatel = value;
                for (int i = 0; i < topOdberatel.Count; i++)
                {
                    topOdberatel[i].Id = i + 1;
                }
            }
        }

        List<B1Wrapper> topDodavatel;
        internal List<B1Wrapper> TopDodavatel
        {
            get
            {
                return topDodavatel;
            }

            set
            {
                topDodavatel = value;
                for (int i = 0; i < topDodavatel.Count; i++)
                {
                    topDodavatel[i].Id = i + 1;
                }
            }
        }
    }
}
