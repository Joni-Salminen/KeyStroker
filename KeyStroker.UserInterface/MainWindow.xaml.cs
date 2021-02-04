using KeyStroker.UI.Viewmodels;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Interop;
using KeyStroker.Logic;
using System;
using System.Diagnostics;
using System.Windows.Input;

namespace KeyStroker.UI {

    public partial class MainWindow : MetroWindow {

        RootViewmodel vm;

        public MainWindow() {
            InitializeComponent();
            HamburgerMenu.SelectedIndex = 0;
            vm = new RootViewmodel(DialogCoordinator.Instance);
            DataContext = vm;       
        }
        
        private void HamburgerMenu_ItemClick(object sender, MahApps.Metro.Controls.ItemClickEventArgs e) {
            // set the content
            this.HamburgerMenu.Content = e.ClickedItem;
            // close the pane
            this.HamburgerMenu.IsPaneOpen = false;  
        }

        private void OnKeyDown(object sender, System.Windows.Input.KeyEventArgs e) {
            vm.ButtonSpammerVM.ButtonPressCaptured(e.Key);
        }

      



        private void OnHwndReady(object sender, System.EventArgs e) {
            // listener = new BackgroundKeyListener(new WindowInteropHelper(this).Handle);
            GlobalHotkeyListener l = GlobalHotkeyListener.Instance;
            l.SetWindowHandle(new WindowInteropHelper(this).Handle);

            l.RegisterHotKey(999, 0x0001, 0x41);   //0x0001
            l.RegisterHotKey(111, 0x0002, 0x42);

        }
    }
}
