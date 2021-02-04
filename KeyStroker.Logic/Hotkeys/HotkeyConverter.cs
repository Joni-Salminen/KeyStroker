using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;

namespace KeyStroker.Logic.Hotkeys {
    public static class HotkeyConverter {

        public static Key VirtualToWpfKey(Int32 virtualKey) {
            return KeyInterop.KeyFromVirtualKey(virtualKey);
        }

        public static Int32 WpfKeyToVirtual(Key WpfKey) {
            return KeyInterop.VirtualKeyFromKey(WpfKey);
        }

        public static List<Key> WpfModifiersFromVirtual(Int32 modifier) {

            List<Key> keys = new List<Key>();
            if ((modifier & (int)HotkeyModifier.ALT) == (int)HotkeyModifier.ALT)
                keys.Add(Key.LeftAlt);
            if ((modifier & (int)HotkeyModifier.CTRL) == (int)HotkeyModifier.CTRL)
                keys.Add(Key.LeftCtrl);
            if ((modifier & (int)HotkeyModifier.SHIFT) == (int)HotkeyModifier.SHIFT)
                keys.Add(Key.LeftShift);
            if ((modifier & (int)HotkeyModifier.WIN) == (int)HotkeyModifier.WIN)
                keys.Add(Key.LWin);

            return keys;
        }


        /* This method needs redesign */

        /*
        public static Int32 VirtualFromWpfModifier(List<Key> mods) {

            Int32 mods = 0x00;

            foreach(Key k in mods) {
                switch (k) {
                    case Key.LeftAlt:
                    case Key.RightAlt: mods += (int)HotkeyModifier.ALT;  break;
                    case Key.LeftCtrl:
                    case Key.RightCtrl: mods += (int)HotkeyModifier.CTRL; break;
                    case Key.LeftShift:
                    case Key.RightShift: mods += (int)HotkeyModifier.SHIFT; break;
                    case Key.LWin:
                    case Key.RWin: mods += (int)HotkeyModifier.WIN; break;
                    default: Debug.WriteLine("Got Uknown modifier -> " + k.ToString()); break;
                }
            }
            return mods;
        }
        */
    }
}
