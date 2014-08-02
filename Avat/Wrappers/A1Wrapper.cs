using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator;
using System.ComponentModel;

namespace Avat.Wrappers
{
    class A1Wrapper : CommonWrapper
    {
        internal A1 a1;

        public static implicit operator A1(A1Wrapper a)
        {
            return a.a1;
        }

        public A1Wrapper(A1 a1)
        {
            this.a1 = a1;
            id = ItemCounter.Next;
        }

        // akceptuje sa aj a2
        public A1Wrapper(A2 a2)
        {
            this.a1 = new A1();
            a1.Den = a2.Den;
            a1.F = a2.F;
            a1.KOpr = a2.KOpr;
            a1.KOprSpecified = a2.KOprSpecified;
            a1.Odb = a2.Odb;
            a1.Z = a2.Z;

            id = ItemCounter.Next;
        }

        [DisplayName("#")]
        public int Id
        {
            get
            {
                return id;
            }
        }

        [DisplayName("IČ odberateľa")]
        public string Odberatel
        {
            get
            {
                return a1.Odb;
            }
            set
            {
                a1.Odb = value;
            }
        }

        [DisplayName("Odberateľ")]
        public string OdberatelName
        {
            get
            {
                var found = Common.GetTaxPayer(Odberatel);
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
                return a1.F;
            }
            set
            {
                a1.F = value;
            }
        }

        [DisplayName("Dátum dodania")]
        public DateTime DatumDod
        {
            get
            {
                return a1.Den;
            }
            set
            {
                a1.Den = value;
            }
        }

        [DisplayName("Základ dane (€)")]
        public decimal ZakladDane
        {
            get
            {
                return a1.Z;
            }
            set
            {
                a1.Z = value;
            }
        }

        [DisplayName("Suma dane (€)")]
        public decimal SumaDane
        {
            get
            {
                return a1.D;
            }
            set
            {
                a1.D = value;
            }
        }

        [DisplayName("Sadzba dane (%)")]
        public decimal? SadzbaDane
        {
            get
            {
                switch (a1.S)
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
                    a1.S = SadzbaDaneType.Item10;
                else if (value == 20)
                    a1.S = SadzbaDaneType.Item20;
                else
                    a1.S = SadzbaDaneType.Missing;
            }
        }

        [DisplayName("Kód opravy")]
        public string KodOpravy
        {
            get
            {
                return a1.KOprSpecified ? a1.KOpr.ToString().Replace("Item", string.Empty) : string.Empty;
            }
            set
            {
                try
                {
                    a1.KOprSpecified = false;
                    if (value == "1")
                    {
                        a1.KOpr = KodOpravyType.Item1;
                        a1.KOprSpecified = true;
                    }
                    if (value == "2")
                    {
                        a1.KOpr = KodOpravyType.Item2;
                        a1.KOprSpecified = true;
                    }
                }
                catch (Exception) {}
            }
        }
    }
}
