using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using AvatValidator;

namespace Avat.Wrappers
{
    class C1Wrapper
    {
        C1 c1;

        public static implicit operator C1(C1Wrapper a)
        {
            return a.c1;
        }

        public C1Wrapper(C1 c1)
        {
            this.c1 = c1;
        }

        [DisplayName("IČ odberateľa")]
        public string Odberatel
        {
            get
            {
                return c1.Odb;
            }
            set
            {
                c1.Odb = value;
            }
        }

        [DisplayName("Číslo opravnej faktúry")]
        public string FakturaOpr
        {
            get
            {
                return c1.FO;
            }
            set
            {
                c1.FO = value;
            }
        }

        [DisplayName("Číslo pôvodnej faktúry")]
        public string FakturaPov
        {
            get
            {
                return c1.FP;
            }
            set
            {
                c1.FP = value;
            }
        }

        [DisplayName("Rozdiel základu dane (€)")]
        public decimal ZakladDaneRozdiel
        {
            get
            {
                return c1.ZR;
            }
            set
            {
                c1.ZR = value;
            }
        }

        [DisplayName("Rozdiel sumy dane (€)")]
        public decimal SumaDaneRozdiel
        {
            get
            {
                return c1.DR;
            }
            set
            {
                c1.DR = value;
            }
        }

        [DisplayName("Rozdiel sumy je zadaný")]
        public bool RozdielSumyZadane
        {
            get
            {
                return c1.DRSpecified;
            }
            set
            {
                c1.DRSpecified = value;
            }
        }

        [DisplayName("Sadzba dane (%)")]
        public decimal? SadzbaDane
        {
            get
            {
                switch (c1.S)
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
                    c1.S = SadzbaDaneType.Item10;
                else if (value == 20)
                    c1.S = SadzbaDaneType.Item20;
                else
                    c1.S = SadzbaDaneType.Missing;
            }
        }

        [DisplayName("Kód tovaru")]
        public string KodTovaru
        {
            get
            {
                return c1.TK;
            }
            set
            {
                c1.TK = value;
            }
        }

        [DisplayName("Druh tovaru")]
        public string DruhTovaru
        {
            get
            {
                return c1.TDSpecified ? c1.TD.ToString() : string.Empty;
            }
            set
            {
                try
                {
                    c1.TDSpecified = false;
                    if (value == "IO")
                    {
                        c1.TD = DruhTovaruType.IO;
                        c1.TDSpecified = true;
                    }
                    if (value == "MT")
                    {
                        c1.TD = DruhTovaruType.MT;
                        c1.TDSpecified = true;
                    }
                }
                catch (Exception) { }
            }
        }

        [DisplayName("Množstvo")]
        public decimal Mnozstvo
        {
            get
            {
                return c1.Mn;
            }
            set
            {
                c1.Mn = value;
            }
        }

        [DisplayName("Množstvo je zadané")]
        public bool MnozstvoZadane
        {
            get
            {
                return c1.MnSpecified;
            }
            set
            {
                c1.MnSpecified = value;
            }
        }

        [DisplayName("Merná jednotka")]
        public string MernaJednotka
        {
            get
            {
                return c1.MJSpecified ? c1.MJ.ToString() : string.Empty;
            }
            set
            {
                try
                {
                    c1.MJSpecified = false;
                    if (value == "kg")
                    {
                        c1.MJ = MJType.kg;
                        c1.MJSpecified = true;
                    }
                    if (value == "ks")
                    {
                        c1.MJ = MJType.ks;
                        c1.MJSpecified = true;
                    }
                    if (value == "m")
                    {
                        c1.MJ = MJType.m;
                        c1.MJSpecified = true;
                    }
                    if (value == "t")
                    {
                        c1.MJ = MJType.t;
                        c1.MJSpecified = true;
                    }
                }
                catch (Exception) { }
            }
        }

        [DisplayName("Kód opravy")]
        public string KodOpravy
        {
            get
            {
                return c1.KOprSpecified ? c1.KOpr.ToString().Replace("Item", string.Empty) : string.Empty;
            }
            set
            {
                try
                {
                    c1.KOprSpecified = false;
                    if (value == "1")
                    {
                        c1.KOpr = KodOpravyType.Item1;
                        c1.KOprSpecified = true;
                    }
                    if (value == "2")
                    {
                        c1.KOpr = KodOpravyType.Item2;
                        c1.KOprSpecified = true;
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
