using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;

namespace KeyStroker.Logic
{
    public delegate void HotkeyPressed();
    public class BackgroundKeyListener
    {

        public event HotkeyPressed hotkeyPressed;

        public BackgroundKeyListener(IntPtr handle)
        {
            this.handle = handle;

            try
            {
                source = HwndSource.FromHwnd(handle);
                source.AddHook(WndProc);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                throw;
            }
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch(msg)
            {
                case WM_HOTKEY:
                {
                    System.Windows.MessageBox.Show("");        
                    hotkeyPressed?.Invoke();
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
        public bool RegisterHotKey(int id, uint modifiers, uint key)
        {
            return RegisterHotKey(source.Handle, id, modifiers, key);
        }

        /// <summary>
        /// Remove registered hotkey
        /// </summary>
        /// <param name="id">Identifier to be removed</param>
        /// <returns></returns>
        public bool UnregisterHotKey(int id)
        {
            return UnregisterHotKey(source.Handle, id);
        }
    }
}
