using KeyStroker.Logic;
using KeyStroker.UI.Utils;
using System.Windows.Input;

namespace KeyStroker.UI.Viewmodels {

    /* Represents UserDefined Key to UI */
    public class ButtonViewmodel : BaseViewmodel {

        private ProgrammableButton btn = new ProgrammableButton();
        
        /* The Button we are focusing on */

        public string KeyCodeStr { get => btn.KeyCode.ToString(); set { } }

        public Key KeyCode {  get => btn.KeyCode; set { btn.KeyCode = value; NotifyPropertyChanged(); } }
        public long Interval { get => btn.Interval; set { btn.Interval = value; NotifyPropertyChanged(); } }
        public bool IsEnabled { get => btn.IsEnabled; set { btn.IsEnabled = value; NotifyPropertyChanged(); } }
        public bool InfinityTimes { get => (btn.RepeatAmount == 0 ? true : false); set { NotifyPropertyChanged(); } }
        public long RepeatAmount { get => btn.RepeatAmount; set { btn.RepeatAmount = value; NotifyPropertyChanged(); } }

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

