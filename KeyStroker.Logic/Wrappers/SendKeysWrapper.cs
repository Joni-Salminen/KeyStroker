using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyStroker.Logic
{
    // Static Wrapper Class for all keysending
    // for future check SendInput from user32.dll
    public static class SendKeysWrapper
    {
        
        public static void SendSingleKey(char key)
        {
            SendKeys.Send(key.ToString());
        }

        public static void SendMultipleKeys(string keys)
        {
            SendKeys.Send(keys);
        }
    }
}
