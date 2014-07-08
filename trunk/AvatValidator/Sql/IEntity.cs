using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AvatValidator.Sql
{
    public interface IEntity
    {
        string GetTableName();

        string GetCreationScript();
    }
}
