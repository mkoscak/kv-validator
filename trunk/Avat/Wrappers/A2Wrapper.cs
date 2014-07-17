using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using AvatValidator;

namespace Avat.Wrappers
{
    class A2Wrapper
    {
        A2 a2;

        public static implicit operator A2(A2Wrapper a)
        {
            return a.a2;
        }

        public A2Wrapper(A2 a2)
        {
            this.a2 = a2;
        }

        [DisplayName("IČ odberateľa")]
        public string Odberatel
        {
            get
            {
                return a2.Odb;
            }
            set
            {
                a2.Odb = value;
            }
        }

        [DisplayName("Číslo faktúry")]
        public string Faktura
        {
            get
            {
                return a2.F;
            }
            set
            {
                a2.F = value;
            }
        }

        [DisplayName("Dátum dodania")]
        public DateTime DatumDod
        {
            get
            {
                return a2.Den;
            }
            set
            {
                a2.Den = value;
            }
        }

        [DisplayName("Základ dane (€)")]
        public decimal ZakladDane
        {
            get
            {
                return a2.Z;
            }
            set
            {
                a2.Z = value;
            }
        }

        [DisplayName("Kód tovaru")]
        public string KodTovaru
        {
            get
            {
                return a2.TK;
            }
            set
            {
                a2.TK = value;
            }
        }

        [DisplayName("Druh tovaru")]
        public string DruhTovaru
        {
            get
            {
                return a2.TDSpecified ? a2.TD.ToString() : string.Empty;
            }
            set
            {
                try
                {
                    a2.TDSpecified = false;
                    if (value == "IO")
                    {
                        a2.TD = DruhTovaruType.IO;
                        a2.TDSpecified = true;
                    }
                    if (value == "MT")
                    {
                        a2.TD = DruhTovaruType.MT;
                        a2.TDSpecified = true;
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
                return a2.Mn;
            }
            set
            {
                a2.Mn = value;
            }
        }

        [DisplayName("Množstvo je zadané")]
        public bool MnozstvoZadane
        {
            get
            {
                return a2.MnSpecified;
            }
            set
            {
                a2.MnSpecified = value;
            }
        }

        [DisplayName("Kód opravy")]
        public string KodOpravy
        {
            get
            {
                return a2.KOprSpecified ? a2.KOpr.ToString().Replace("Item", string.Empty) : string.Empty;
            }
            set
            {
                try
                {
                    a2.KOprSpecified = false;
                    if (value == "1")
                    {
                        a2.KOpr = KodOpravyType.Item1;
                        a2.KOprSpecified = true;
                    }
                    if (value == "2")
                    {
                        a2.KOpr = KodOpravyType.Item2;
                        a2.KOprSpecified = true;
                    }
                }
                catch (Exception) {}
            }
        }
    }
}
