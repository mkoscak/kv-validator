using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Validators.TaxPayerValidator.Entities;

namespace Avat.Wrappers
{
    public class CommonWrapper: IIdHolder
    {
        protected int id = -1;

        #region IIdHolder Members

        public void SetId(int id)
        {
            this.id = id;
        }

        #endregion
    }
}
