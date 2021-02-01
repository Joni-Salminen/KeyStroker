using KeyStroker.UI.Utils;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KeyStroker.UI.Viewmodels {
    public class RootViewmodel : BaseViewmodel {

        private IDialogCoordinator dialogCordinator;

        private ButtonSpammerViewmodel _buttonSpammerVm;
        public ButtonSpammerViewmodel ButtonSpammerVM { get => _buttonSpammerVm; set { _buttonSpammerVm = value; NotifyPropertyChanged(); }}

        public ObservableCollection<ProfileViewmodel> Profiles { get; set; }

        public RootViewmodel(IDialogCoordinator instance) {     
            dialogCordinator = instance;
            ButtonSpammerVM = new ButtonSpammerViewmodel(dialogCordinator);
        }
    }
}
