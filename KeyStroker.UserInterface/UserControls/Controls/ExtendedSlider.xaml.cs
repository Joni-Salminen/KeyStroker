using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace KeyStroker.UI.UserControls.Controls {
    /// <summary>
    /// Interaction logic for ExtendedSlider.xaml
    /// </summary>
    public partial class ExtendedSlider : UserControl {
        public ExtendedSlider() {
            InitializeComponent();
        }

        public string ValueUnit {
            get { return (string)GetValue(ValueUnitProperty); }
            set { SetValue(ValueUnitProperty, value); }
        }
        public static readonly DependencyProperty ValueUnitProperty =
            DependencyProperty.Register("ValueUnit", typeof(string), typeof(ExtendedSlider), new PropertyMetadata(null));

        public string HelperText {
            get { return (string)GetValue(HelperTextProperty); }
            set { SetValue(HelperTextProperty, value); }
        }
        public static readonly DependencyProperty HelperTextProperty =
            DependencyProperty.Register("HelperText", typeof(string), typeof(ExtendedSlider), new PropertyMetadata(null));

        /* Slider Properties  */
        public long CurrentValue {
            get { return (long)GetValue(CurrentValueProperty); }
            set { SetValue(CurrentValueProperty, value); }
        }
        public static readonly DependencyProperty CurrentValueProperty =
            DependencyProperty.Register("CurrentValue", typeof(long), typeof(ExtendedSlider), new PropertyMetadata());

        public long MinValue {
            get { return (long)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }
        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register("MinValue", typeof(long), typeof(ExtendedSlider), new PropertyMetadata(null));

        public long MaxValue {
            get { return (long)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }
        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register("MaxValue", typeof(long), typeof(ExtendedSlider), new PropertyMetadata(null));

        public long TickAmount { 
            get { return (long)GetValue(TickAmountProperty); }
            set { SetValue(TickAmountProperty, value); }
        }
        public static readonly DependencyProperty TickAmountProperty =
            DependencyProperty.Register("TickAmount", typeof(long), typeof(ExtendedSlider), new PropertyMetadata(null));
       
    }
}
