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

        internal List<A1Wrapper> TopOdberatel = new List<A1Wrapper>();
        internal List<B1Wrapper> TopDodavatel = new List<B1Wrapper>();
    }
}
