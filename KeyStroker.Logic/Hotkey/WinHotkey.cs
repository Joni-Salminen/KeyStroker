using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KeyStroker.Logic.Hotkey {
    public class WinHotkey {

        private HotkeyModifier[] Modifiers = null;

        public bool Alt { get; private set; } = false;
        public bool Shift { get; private set; } = false;
        public bool WinKey { get; private set; } = false;
        public bool Ctrl { get; private set; } = false;

        public IntPtr KeyCode { get; set; }   


        public WinHotkey(IntPtr WinHotkey) {
            KeyCode = WinHotkey;
            parseWindowsHotkeyData();
        }


        private void parseWindowsHotkeyData() {

            



        }


        public Key GetKey() {
            return KeyInterop.KeyFromVirtualKey((KeyCode.ToInt32() >> 16));
        }
        public Int32 GetKeyCode() {
            return KeyCode.ToInt32();
        }
        public Int32 GetModifiers() {
            return (KeyCode.ToInt32() & 0xFFFF);
        }

        public HotkeyModifier[] GetModifiers() {

        }


    }
}
