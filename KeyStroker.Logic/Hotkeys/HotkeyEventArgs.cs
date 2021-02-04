using System;

namespace KeyStroker.Logic.Hotkeys {
    public class HotkeyEventArgs : EventArgs {

        /* Data as it is from Windows hotkey event */
        public IntPtr WinHotkey { get; set; } = IntPtr.Zero;
        
        /* Only the Virtual Keycode parsed out of full data */
        public Int32 VirtualKeyCode { get; set; } 

        /* Modifiers only */
        public Int32 Modifiers { get; set; }

        public HotkeyEventArgs(IntPtr WinHotkeyData) {
            this.WinHotkey = WinHotkeyData;
            this.VirtualKeyCode = WinHotkey.ToInt32() >> 16;
            this.Modifiers = WinHotkey.ToInt32() & 0xFFFF;
        }
    }
}
