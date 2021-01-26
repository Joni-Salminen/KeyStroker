using MahApps.Metro.Controls;

namespace KeyStroker.UI {
 
    public partial class MainWindow : MetroWindow {
        public MainWindow() {
            InitializeComponent();
            HamburgerMenu.SelectedIndex = 0;
        }

        private void HamburgerMenu_ItemClick(object sender, MahApps.Metro.Controls.ItemClickEventArgs e)
        {
            // set the content
            this.HamburgerMenu.Content = e.ClickedItem;
            // close the pane
            this.HamburgerMenu.IsPaneOpen = false;
            //(DataContext as MainViewModel).HamburgerMenuIndex = e.ClickedItem;
        }


    }
}
