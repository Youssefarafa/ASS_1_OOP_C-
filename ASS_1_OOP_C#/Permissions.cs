using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_1_OOP_C_
{
    [Flags]
    public enum Permissions : byte
    {
        None=0,Read = 1, Write=2, Delete=4, Execute=8
    }
}
