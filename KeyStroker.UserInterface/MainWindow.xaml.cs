using KeyStroker.UI.Viewmodels;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

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
    }
}
