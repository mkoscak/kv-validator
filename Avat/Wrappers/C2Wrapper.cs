using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using AvatValidator;

namespace Avat.Wrappers
{
    class C2Wrapper : CommonWrapper
    {
        internal C2 c2;

        public static implicit operator C2(C2Wrapper a)
        {
            return a.c2;
        }

        public C2Wrapper()
        {
            this.c2 = new C2();
            id = ItemCounter.Next;
        }

        public C2Wrapper(C2 c2)
        {
            this.c2 = c2;
            id = ItemCounter.Next;
        }

        [DisplayName("#")]
        public int Id
        {
            get
            {
                if (id == -1)
                    id = ItemCounter.Next;
                return id;
            }
        }

        [DisplayName("IČ dodávateľa")]
        public string Dodavatel
        {
            get
            {
                return c2.Dod;
            }
            set
            {
                c2.Dod = value;
            }
        }

        [DisplayName("Názov spoločnosti")]
        public string DodavatelName
        {
            get
            {
                var found = Common.GetTaxPayer(Dodavatel);
                if (found == null)
                    return string.Empty;

                return found.Nazov;
            }
        }

        [DisplayName("Číslo opravnej faktúry")]
        public string FakturaOpr
        {
            get
            {
                return c2.FO;
            }
            set
            {
                c2.FO = value;
            }
        }

        [DisplayName("Číslo pôvodnej faktúry")]
        public string FakturaPov
        {
            get
            {
                return c2.FP;
            }
            set
            {
                c2.FP = value;
            }
        }

        [DisplayName("Rozdiel základu dane (€)")]
        public decimal ZakladDaneRozdiel
        {
            get
            {
                return c2.ZR;
            }
            set
            {
                c2.ZR = value;
            }
        }

        [DisplayName("Rozdiel sumy dane (€)")]
        public decimal SumaDaneRozdiel
        {
            get
            {
                return c2.DR;
            }
            set
            {
                c2.DR = value;
            }
        }

        [DisplayName("Sadzba dane (%)")]
        public decimal? SadzbaDane
        {
            get
            {
                switch (c2.S)
                {
                    case SadzbaDaneType.Item10:
                        return 10;
                    case SadzbaDaneType.Item20:
                        return 20;

                    case SadzbaDaneType.Missing:
                    default:
                        return null;
                }
            }
            set
            {
                if (value == 10)
                    c2.S = SadzbaDaneType.Item10;
                else if (value == 20)
                    c2.S = SadzbaDaneType.Item20;
                else
                    c2.S = SadzbaDaneType.Missing;
            }
        }

        [DisplayName("Rozdiel v sume odpočítenej dane (€)")]
        public decimal OdpocitanaDanRozdiel
        {
            get
            {
                return c2.OR;
            }
            set
            {
                c2.OR = value;
            }
        }

        [DisplayName("Kód opravy")]
        public string KodOpravy
        {
            get
            {
                return c2.KOprSpecified ? c2.KOpr.ToString().Replace("Item", string.Empty) : string.Empty;
            }
            set
            {
                try
                {
                    c2.KOprSpecified = false;
                    if (value == "1")
                    {
                        c2.KOpr = KodOpravyType.Item1;
                        c2.KOprSpecified = true;
                    }
                    if (value == "2")
                    {
                        c2.KOpr = KodOpravyType.Item2;
                        c2.KOprSpecified = true;
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
