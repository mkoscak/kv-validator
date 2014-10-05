using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator;
using System.ComponentModel;

namespace Avat.Wrappers
{
    class B2Wrapper : CommonWrapper
    {
        internal B2 b2;

        public static implicit operator B2(B2Wrapper a)
        {
            return a.b2;
        }

        public B2Wrapper()
        {
            this.b2 = new B2();
            id = ItemCounter.Next;
        }

        public B2Wrapper(B2 b2)
        {
            this.b2 = b2;
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
                return b2.Dod;
            }
            set
            {
                b2.Dod = value;
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
                return b2.F;
            }
            set
            {
                b2.F = value;
            }
        }

        [DisplayName("Dátum dodania")]
        public DateTime DatumDod
        {
            get
            {
                return b2.Den;
            }
            set
            {
                b2.Den = value;
            }
        }

        [DisplayName("Základ dane (€)")]
        public decimal ZakladDane
        {
            get
            {
                return b2.Z;
            }
            set
            {
                b2.Z = value;
            }
        }

        [DisplayName("Suma dane (€)")]
        public decimal SumaDane
        {
            get
            {
                return b2.D;
            }
            set
            {
                b2.D = value;
            }
        }

        [DisplayName("Sadzba dane (%)")]
        public decimal? SadzbaDane
        {
            get
            {
                switch (b2.S)
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
                    b2.S = SadzbaDaneType.Item10;
                else if (value == 20)
                    b2.S = SadzbaDaneType.Item20;
                else
                    b2.S = SadzbaDaneType.Missing;
            }
        }

        [DisplayName("Odpočítaná daň (€)")]
        public decimal Odpocet
        {
            get
            {
                return b2.O;
            }
            set
            {
                b2.O = value;
            }
        }

        [DisplayName("Kód opravy")]
        public string KodOpravy
        {
            get
            {
                return b2.KOprSpecified ? b2.KOpr.ToString().Replace("Item", string.Empty) : string.Empty;
            }
            set
            {
                try
                {
                    b2.KOprSpecified = false;
                    if (value == "1")
                    {
                        b2.KOpr = KodOpravyType.Item1;
                        b2.KOprSpecified = true;
                    }
                    if (value == "2")
                    {
                        b2.KOpr = KodOpravyType.Item2;
                        b2.KOprSpecified = true;
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
