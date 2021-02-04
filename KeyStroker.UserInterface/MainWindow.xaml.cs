using KeyStroker.UI.Viewmodels;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using KeyStroker.Logic.Hotkeys;
using System.Windows.Interop;
using System;

namespace KeyStroker.UI {

    public partial class MainWindow : MetroWindow {

        RootViewmodel vm;
        GlobalHotkeyListener hotKeyListener;
        public MainWindow() {
            InitializeComponent();
            HamburgerMenu.SelectedIndex = 0;
            vm = new RootViewmodel(DialogCoordinator.Instance);
            DataContext = vm;

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e) {

            IntPtr windowHandle = new WindowInteropHelper(this).Handle;
            hotKeyListener = GlobalHotkeyListener.Instance;
            hotKeyListener.SetWindowHandle(windowHandle);

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
    }
}
