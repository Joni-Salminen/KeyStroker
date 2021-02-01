using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyStroker.UI.UserControls.Tabs
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

      

        private void OnSelectionStarting(object sender, EventArgs e) {
            Flipper.SelectedIndex = 0;
        }

        private void OnSelectionEnding(object sender, EventArgs e) {
            if (ProfileCombo.SelectedItem != null) {
                Flipper.SelectedIndex = 1;
            }
        }
    }
}
