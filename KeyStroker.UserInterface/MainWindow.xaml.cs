using KeyStroker.UI.Viewmodels;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Interop;
using KeyStroker.Logic;

namespace KeyStroker.UI {

    public partial class MainWindow : MetroWindow {

        RootViewmodel vm;
        BackgroundKeyListener listener;
        public MainWindow() {
            InitializeComponent();
            HamburgerMenu.SelectedIndex = 0;
            vm = new RootViewmodel(DialogCoordinator.Instance);
            DataContext = vm;

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            listener = new BackgroundKeyListener(new WindowInteropHelper(this).Handle);
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
