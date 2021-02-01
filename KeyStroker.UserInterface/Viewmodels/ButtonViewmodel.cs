using KeyStroker.Logic;
using KeyStroker.UI.Utils;
using System.Windows.Input;

namespace KeyStroker.UI.Viewmodels {

    /* Represents UserDefined Key to UI */
    public class ButtonViewmodel : BaseViewmodel {

        private readonly ProgrammableButton btn = new ProgrammableButton();
        
        /* UI only properties */
        public string KeyCodeStr { get => btn.KeyCode.ToString(); set { } }
        public bool InfinityTimes { get => (btn.RepeatAmount == 0); set { NotifyPropertyChanged("InfinityTimes"); } }


        public Key KeyCode {  get => btn.KeyCode; set { btn.KeyCode = value; NotifyPropertyChanged(); NotifyPropertyChanged("KeyCodeStr"); } }
        public long Interval { get => btn.Interval; set { btn.Interval = value; NotifyPropertyChanged();  } }
        public bool IsEnabled { get => btn.IsEnabled; set { btn.IsEnabled = value; NotifyPropertyChanged(); } }      
        public long RepeatAmount { get => btn.RepeatAmount; set { btn.RepeatAmount = value; NotifyPropertyChanged(); NotifyPropertyChanged("InfinityTimes"); } }


        public ButtonViewmodel() {}
        public ButtonViewmodel(ProgrammableButton button) { btn = button; }

        /* TO-DO remove in future, just for testing purposes before core is finished */
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

