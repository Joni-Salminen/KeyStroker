using KeyStroker.UI.Utils;
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

namespace KeyStroker.UI.UserControls.Tabs {
    /// <summary>
    /// Interaction logic for CreateProfileDialog.xaml
    /// </summary>
    public partial class CreateProfileDialog : UserControl {
        public CreateProfileDialog() {
            InitializeComponent();
        }

        public string ProfileName {
            get { return (string)GetValue(ProfileNameProperty); }
            set { SetValue(ProfileNameProperty, value); }
        }
        public static readonly DependencyProperty ProfileNameProperty =
            DependencyProperty.Register("ProfileName", typeof(string), typeof(CreateProfileDialog), new PropertyMetadata(null));

        public BaseAction ActionConfirm {
            get { return (BaseAction)GetValue(ActionConfirmProperty); }
            set { SetValue(ActionConfirmProperty, value); }
        }
        public static readonly DependencyProperty ActionConfirmProperty =
            DependencyProperty.Register("ActionConfirm", typeof(BaseAction), typeof(CreateProfileDialog), new PropertyMetadata(null));

        public BaseAction ActionBack {
            get { return (BaseAction)GetValue(ActionBackProperty); }
            set { SetValue(ActionBackProperty, value); }
        }
        public static readonly DependencyProperty ActionBackProperty =
            DependencyProperty.Register("ActionBack", typeof(BaseAction), typeof(CreateProfileDialog), new PropertyMetadata(null));


    }
}
