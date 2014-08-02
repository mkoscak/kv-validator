using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator;
using System.ComponentModel;

namespace Avat.Wrappers
{
    class D1Wrapper : CommonWrapper
    {
        internal D1 d1;

        public static implicit operator D1(D1Wrapper a)
        {
            return a.d1;
        }

        public D1Wrapper(D1 d1)
        {
            this.d1 = d1;
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

        [DisplayName("Suma obratov (€)")]
        public decimal SumaObratov
        {
            get
            {
                return d1.SumaObratov;
            }
            set
            {
                d1.SumaObratov = value;
            }
        }

        [DisplayName("Základ dane (€)")]
        public decimal ZakladDane
        {
            get
            {
                return d1.Z;
            }
            set
            {
                d1.Z = value;
            }
        }

        [DisplayName("Suma dane (€)")]
        public decimal SumaDane
        {
            get
            {
                return d1.D;
            }
            set
            {
                d1.D = value;
            }
        }

        [DisplayName("Celková suma základov dane (€)")]
        public decimal ZakladDaneOpr
        {
            get
            {
                return d1.ZZn;
            }
            set
            {
                d1.ZZn = value;
            }
        }

        [DisplayName("Celková suma dane (€)")]
        public decimal SumaDaneOpr
        {
            get
            {
                return d1.DZn;
            }
            set
            {
                d1.DZn = value;
            }
        }

        [DisplayName("Kód opravy")]
        public string KodOpravy
        {
            get
            {
                return d1.KOprSpecified ? d1.KOpr.ToString().Replace("Item", string.Empty) : string.Empty;
            }
            set
            {
                try
                {
                    d1.KOprSpecified = false;
                    if (value == "1")
                    {
                        d1.KOpr = KodOpravyType.Item1;
                        d1.KOprSpecified = true;
                    }
                    if (value == "2")
                    {
                        d1.KOpr = KodOpravyType.Item2;
                        d1.KOprSpecified = true;
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
