using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator;
using System.ComponentModel;

namespace Avat.Wrappers
{
    class B1Wrapper : CommonWrapper
    {
        internal B1 b1;

        public static implicit operator B1(B1Wrapper a)
        {
            return a.b1;
        }

        public B1Wrapper()
        {
            this.b1 = new B1();
            id = ItemCounter.Next;
        }

        public B1Wrapper(B1 b1)
        {
            this.b1 = b1;
            id = ItemCounter.Next;
        }

        public B1Wrapper(B2 b2)
        {
            this.b1 = new B1();
            b1.D = b2.D;
            b1.Den = b2.Den;
            b1.Dod = b2.Dod;
            b1.F = b2.F;
            b1.KOpr = b2.KOpr;
            b1.KOprSpecified = b2.KOprSpecified;
            b1.O = b2.O;
            b1.S = b2.S;
            b1.Z = b2.Z;

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

            internal set
            {
                id = value;
            }
        }

        [DisplayName("IČ dodávateľa")]
        public string Dodavatel
        {
            get
            {
                return b1.Dod;
            }
            set
            {
                b1.Dod = value;
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

        [DisplayName("Číslo faktúry")]
        public string Faktura
        {
            get
            {
                return b1.F;
            }
            set
            {
                b1.F = value;
            }
        }

        [DisplayName("Dátum dodania")]
        public DateTime DatumDod
        {
            get
            {
                return b1.Den;
            }
            set
            {
                b1.Den = value;
            }
        }

        [DisplayName("Základ dane (€)")]
        public decimal ZakladDane
        {
            get
            {
                return b1.Z;
            }
            set
            {
                b1.Z = value;
            }
        }

        [DisplayName("Suma dane (€)")]
        public decimal SumaDane
        {
            get
            {
                return b1.D;
            }
            set
            {
                b1.D = value;
            }
        }

        [DisplayName("Sadzba dane (%)")]
        public decimal? SadzbaDane
        {
            get
            {
                switch (b1.S)
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
                    b1.S = SadzbaDaneType.Item10;
                else if (value == 20)
                    b1.S = SadzbaDaneType.Item20;
                else
                    b1.S = SadzbaDaneType.Missing;
            }
        }

        [DisplayName("Odpočítaná daň (€)")]
        public decimal Odpocet
        {
            get
            {
                return b1.O;
            }
            set
            {
                b1.O = value;
            }
        }

        [DisplayName("Kód opravy")]
        public string KodOpravy
        {
            get
            {
                return b1.KOprSpecified ? b1.KOpr.ToString().Replace("Item", string.Empty) : string.Empty;
            }
            set
            {
                try
                {
                    b1.KOprSpecified = false;
                    if (value == "1")
                    {
                        b1.KOpr = KodOpravyType.Item1;
                        b1.KOprSpecified = true;
                    }
                    if (value == "2")
                    {
                        b1.KOpr = KodOpravyType.Item2;
                        b1.KOprSpecified = true;
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
