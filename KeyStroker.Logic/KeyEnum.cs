using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStroker.Logic
{
    public enum ModifierList : uint
    {
        NOMOD = 0x0000,
        ALT = 0x0001,
        CTRL = 0x0002,
        SHIFT = 0x0004,
        WIN = 0x0008
    }
}
