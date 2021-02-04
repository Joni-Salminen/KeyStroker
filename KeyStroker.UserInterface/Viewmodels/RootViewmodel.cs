using KeyStroker.Logic.Hotkeys;
using KeyStroker.Logic.Models;
using KeyStroker.UI.Utils;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KeyStroker.UI.Viewmodels {
    public class RootViewmodel : BaseViewmodel {

        private GlobalHotkeyListener listener;
        private ObservableCollection<ProfileViewmodel> profiles = new ObservableCollection<ProfileViewmodel>();
        private IDialogCoordinator dialogCordinator;
        private ButtonSpammerViewmodel _buttonSpammerVm;
        private bool creatingNewProfile = false;
        private bool isFlipped = false;
        private string newProfileName;
        private ProfileViewmodel currentProfile;

        #region Actions

        private BaseAction createNewProfile;
        private BaseAction actionConfirm;
        private BaseAction actionBack;

        public BaseAction CreateNewProfile {
            get {
                createNewProfile = new BaseAction(CreateNew);
                return this.createNewProfile;
            }
            set { createNewProfile = value; }
        }
        public BaseAction ActionConfirm {
            get {
                actionConfirm = new BaseAction(Confirm);
                return this.actionConfirm;
            }
            set { actionConfirm = value; }
        }
        public BaseAction ActionBack {
            get {
                actionBack = new BaseAction(Back);
                return this.actionBack;
            }
            set { actionBack = value; }
        }

        #endregion

        public string ProfileName { get => newProfileName; set { newProfileName = value; NotifyPropertyChanged(); } }
        public bool CreatingNewProfile { get => creatingNewProfile; set { creatingNewProfile = value; NotifyPropertyChanged(); } }
        public bool IsFlipped { get => isFlipped; set { isFlipped = value; NotifyPropertyChanged(); }}
        public ProfileViewmodel SelectedProfile { get => currentProfile; set { currentProfile = value;  NotifyPropertyChanged(); }}

        public ButtonSpammerViewmodel ButtonSpammerVM { get => _buttonSpammerVm; set { _buttonSpammerVm = value; NotifyPropertyChanged(); }}
        public ObservableCollection<ProfileViewmodel> Profiles { get => profiles; private set { profiles = value; NotifyPropertyChanged(); }}

        public RootViewmodel(IDialogCoordinator instance) {     
            dialogCordinator = instance;
            ButtonSpammerVM = new ButtonSpammerViewmodel(dialogCordinator);
            Profiles.Add(new ProfileViewmodel(new Profile("Just a Test")));
            Profiles.Add(new ProfileViewmodel(new Profile("Another one")));
            listener = GlobalHotkeyListener.Instance;
            listener.OnHotketDetected += OnHotkeyDetected;
        }

        private void OnHotkeyDetected(HotkeyEventArgs e) {



           
        }

        private async void CreateNew() {
            CreatingNewProfile = true;
        }
        private async void Back() {
            CreatingNewProfile = false;
        }
        private async void Confirm() {
            CreatingNewProfile = false;
        }

    }
}
