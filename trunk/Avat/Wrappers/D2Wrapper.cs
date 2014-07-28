using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator;
using System.ComponentModel;

namespace Avat.Wrappers
{
    class D2Wrapper : IIdHolder
    {
        internal D2 d2;

        public static implicit operator D2(D2Wrapper a)
        {
            return a.d2;
        }

        public D2Wrapper(D2 d2)
        {
            this.d2 = d2;
            id = ItemCounter.Next;
        }

        int id = -1;
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

        [DisplayName("Základ dane (€)")]
        public decimal ZakladDane
        {
            get
            {
                return d2.Z;
            }
            set
            {
                d2.Z = value;
            }
        }

        [DisplayName("Suma dane (€)")]
        public decimal SumaDane
        {
            get
            {
                return d2.D;
            }
            set
            {
                d2.D = value;
            }
        }

        [DisplayName("Celková suma základov dane (€)")]
        public decimal ZakladDaneOpr
        {
            get
            {
                return d2.ZZn;
            }
            set
            {
                d2.ZZn = value;
            }
        }

        [DisplayName("Celková suma dane (€)")]
        public decimal SumaDaneOpr
        {
            get
            {
                return d2.DZn;
            }
            set
            {
                d2.DZn = value;
            }
        }

        [DisplayName("Kód opravy")]
        public string KodOpravy
        {
            get
            {
                return d2.KOprSpecified ? d2.KOpr.ToString().Replace("Item", string.Empty) : string.Empty;
            }
            set
            {
                try
                {
                    d2.KOprSpecified = false;
                    if (value == "1")
                    {
                        d2.KOpr = KodOpravyType.Item1;
                        d2.KOprSpecified = true;
                    }
                    if (value == "2")
                    {
                        d2.KOpr = KodOpravyType.Item2;
                        d2.KOprSpecified = true;
                    }
                }
                catch (Exception) { }
            }
        }

        #region IIdHolder Members

        public void SetId(int id)
        {
            this.id = id;
        }

        #endregion
    }
}
