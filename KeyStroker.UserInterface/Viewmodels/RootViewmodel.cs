using KeyStroker.UI.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeyStroker.UI.Viewmodels {
    public class RootViewmodel : BaseViewmodel {

        private ButtonSpammerViewmodel _buttonSpammerVm;
        public ButtonSpammerViewmodel ButtonSpammerVM { get => _buttonSpammerVm; set { _buttonSpammerVm = value; NotifyPropertyChanged(); }}


        public RootViewmodel() {
            ButtonSpammerVM = new ButtonSpammerViewmodel(); 



        }
    }
}
