using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator;
using System.ComponentModel;

namespace Avat.Wrappers
{
    class B3Wrapper
    {
        B3 b3;

        public static implicit operator B3(B3Wrapper a)
        {
            return a.b3;
        }

        public B3Wrapper(B3 b3)
        {
            this.b3 = b3;
        }

        [DisplayName("Celková suma základov dane (€)")]
        public decimal ZakladDane
        {
            get
            {
                return b3.Z;
            }
            set
            {
                b3.Z = value;
            }
        }

        [DisplayName("Suma dane (€)")]
        public decimal SumaDane
        {
            get
            {
                return b3.D;
            }
            set
            {
                b3.D = value;
            }
        }

        [DisplayName("Celková suma odpočítanej dane (€)")]
        public decimal Odpocet
        {
            get
            {
                return b3.O;
            }
            set
            {
                b3.O = value;
            }
        }

        [DisplayName("Kód opravy")]
        public string KodOpravy
        {
            get
            {
                return b3.KOprSpecified ? b3.KOpr.ToString().Replace("Item", string.Empty) : string.Empty;
            }
            set
            {
                try
                {
                    b3.KOprSpecified = false;
                    if (value == "1")
                    {
                        b3.KOpr = KodOpravyType.Item1;
                        b3.KOprSpecified = true;
                    }
                    if (value == "2")
                    {
                        b3.KOpr = KodOpravyType.Item2;
                        b3.KOprSpecified = true;
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
