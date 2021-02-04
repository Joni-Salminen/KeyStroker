using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Windows.Interop;

namespace KeyStroker.Logic {
    public sealed class GlobalHotkeyListener {

        public event HotkeyPressed OnHotkeyPressed;

        private static readonly Lazy<GlobalHotkeyListener> instance = new Lazy<GlobalHotkeyListener>(() => new GlobalHotkeyListener());
        public static GlobalHotkeyListener Instance { get { return instance.Value; } }

        private GlobalHotkeyListener() {
            if (handle == IntPtr.Zero)
                handle = Process.GetCurrentProcess().MainWindowHandle;
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled) {
            switch (msg) {
                case WM_HOTKEY: {
                        System.Windows.MessageBox.Show("");
                        OnHotkeyPressed?.Invoke();
                        break;
                    }
            }

            return IntPtr.Zero;
        }

        private const int WM_HOTKEY = 0x312;
        IntPtr handle;
        HwndSource source;

        #region DLLIMPORTS
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion

        /// <summary>
        /// Register new Hotkey
        /// </summary>
        /// <param name="id">Identifier of the Hotkey</param>
        /// <param name="modifiers">Keys that must be pressed in combination with the key</param>
        /// <param name="key"> Virtual-key code of the hotkey </param>
        /// <returns></returns>
        public bool RegisterHotKey(int id, ModifierKeys modifiers, Key key) {
            //return RegisterHotKey(source.Handle, id, modifiers, key);
            return false;
        }

        /// <summary>
        /// Remove registered hotkey
        /// </summary>
        /// <param name="id">Identifier to be removed</param>
        /// <returns></returns>
        public bool UnregisterHotKey(int id) {
            return UnregisterHotKey(source.Handle, id);
        }


    }
}
