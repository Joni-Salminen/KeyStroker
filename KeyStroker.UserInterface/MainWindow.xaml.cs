using KeyStroker.UI.Viewmodels;
using MahApps.Metro.Controls;

namespace KeyStroker.UI {

    public partial class MainWindow : MetroWindow {

        RootViewmodel model = new RootViewmodel();
        public MainWindow() {
            InitializeComponent();
            HamburgerMenu.SelectedIndex = 0;
            DataContext = model;
        }

        private void HamburgerMenu_ItemClick(object sender, MahApps.Metro.Controls.ItemClickEventArgs e) {
            // set the content
            this.HamburgerMenu.Content = e.ClickedItem;
            // close the pane
            this.HamburgerMenu.IsPaneOpen = false;
            //(DataContext as MainViewModel).HamburgerMenuIndex = e.ClickedItem;
        }


    }
}
