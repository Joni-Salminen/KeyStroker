using KeyStroker.UI.Utils;
using System.Windows.Input;

namespace KeyStroker.UI.Viewmodels {

    /* Represents UserDefined Key to UI */
    public class ButtonViewmodel : BaseViewmodel {

        /* These should come from the datamodel */
        

        /* The Button we are focusing on */

        public string KeyCodeStr { get => key.ToString(); set { } }

        public Key KeyCode {
            get => key;
            set {
                key = value;
                NotifyPropertyChanged();
            }
        }
        public long Interval { get => interval; set { interval = value; NotifyPropertyChanged(); } }
        public bool IsEnabled { get => enabled; set { enabled = value; NotifyPropertyChanged(); } }
        public bool InfinityTimes { get => infiniteTimes; set { infiniteTimes = value; NotifyPropertyChanged(); } }
        public long RepeatAmount { get => repeatAmount; set { repeatAmount = value; NotifyPropertyChanged(); } }

        public ButtonViewmodel() {}

        public ButtonViewmodel(Key keyCode, bool enabled, long interval, long repeatAmount) {
            this.KeyCode = keyCode;
            this.IsEnabled = enabled;
            this.RepeatAmount = repeatAmount;
            this.Interval = interval;
            if (RepeatAmount == 0) {
                InfinityTimes = true;
            }
        }


    }
}

