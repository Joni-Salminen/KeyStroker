using KeyStroker.UI.Utils;
using System.Windows.Input;

namespace KeyStroker.UI.Viewmodels {

    /* Represents UserDefined Key to UI */
    public class ButtonViewmodel : BaseViewmodel {

        private Key key;
        private bool infiniteTimes = true;
        private bool enabled = true;
        private long repeatAmount = 0;
        private long interval = 100;

        /* The Button we are focusing on */
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

        public ButtonViewmodel(Key keyCode, bool enabled, long repeatAmount) {
            this.KeyCode = keyCode;
            this.IsEnabled = enabled;
            this.RepeatAmount = repeatAmount;
            if (RepeatAmount == 0) {
                InfinityTimes = true;
            }
        }


    }
}

