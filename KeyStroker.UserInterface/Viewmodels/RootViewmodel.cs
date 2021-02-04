using KeyStroker.Logic;
using KeyStroker.Logic.Models;
using KeyStroker.UI.Utils;
using MahApps.Metro.Controls.Dialogs;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace KeyStroker.UI.Viewmodels {
    public class RootViewmodel : BaseViewmodel {

        private ObservableCollection<ProfileViewmodel> profiles = new ObservableCollection<ProfileViewmodel>();
        private IDialogCoordinator dialogCordinator;
        private ButtonSpammerViewmodel _buttonSpammerVm;
        private bool creatingNewProfile = false;
        private bool isFlipped = false;
        private string newProfileName;
        private ProfileViewmodel currentProfile;
        private GlobalHotkeyListener hotkeyListener;


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
            hotkeyListener = GlobalHotkeyListener.Instance;
            hotkeyListener.OnHotkeyPressed += OnHotkeyDetected;

        }

        // LEFT ALT 120 == 0001   
        // CTRL 118 == 0002
        // Shift 116 == 0004
        // WIN xx == 0008
        private void OnHotkeyDetected(System.IntPtr param) {
    /*
            var test1 = param.ToInt32() & 0xFFFF;
            if ((test1 & 0x0001) == 0x0001) {
                Debug.WriteLine("Alt was held down");
            }
            else if ((test1 & 0x0002) == 0x0002) {
                Debug.WriteLine("CTRL was held down");
            } else {
                Debug.WriteLine("Alt or CTRL was not held down");
            }

            var key = param.ToInt32() >> 16;
            var mod = param.ToInt32() & 0xFFFF;
            var test = KeyInterop.KeyFromVirtualKey(key);
            var test2 = KeyInterop.KeyFromVirtualKey(mod);

    */
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
