using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avat.Wrappers
{
    class ItemCounter
    {
        static int i = 0;

        public static int Next
        {
            get { return ++i; }
        }

        public static void Reset()
        {
            i = 0;
        }
    }
}
