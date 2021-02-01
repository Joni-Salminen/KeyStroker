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

namespace KeyStroker.UI.UserControls.Controls {
    /// <summary>
    /// Interaction logic for CreateProgButton.xaml
    /// </summary>
    public partial class CreateProgButton : UserControl {
        public CreateProgButton() {
            InitializeComponent();
        }

        /* Header Property */
        public string HeaderText {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }
        public static readonly DependencyProperty HeaderTextProperty =
            DependencyProperty.Register("HeaderText", typeof(string), typeof(CreateProgButton), new PropertyMetadata(null));


        /* IsButtonEnabledProperty */
        public bool IsButtonEnabled {
            get { return (bool)GetValue(IsButtonEnabledProperty); }
            set { SetValue(IsButtonEnabledProperty, value); }
        }
        public static readonly DependencyProperty IsButtonEnabledProperty =
            DependencyProperty.Register("IsButtonEnabled", typeof(bool), typeof(CreateProgButton), new PropertyMetadata(null));

        /* Amount Slider */
        public int AmountValue {
            get { return (int)GetValue(AmountValueProperty); }
            set { SetValue(AmountValueProperty, value); }
        }
        public static readonly DependencyProperty AmountValueProperty =
            DependencyProperty.Register("AmountValue", typeof(int), typeof(CreateProgButton), new PropertyMetadata(null));


        /* Interval Slider */
        public int IntervalValue {
            get { return (int)GetValue(IntervalValueProperty); }
            set { SetValue(IntervalValueProperty, value); }
        }
        public static readonly DependencyProperty IntervalValueProperty =
            DependencyProperty.Register("IntervalValue", typeof(int), typeof(CreateProgButton), new PropertyMetadata(null));


    }
}
