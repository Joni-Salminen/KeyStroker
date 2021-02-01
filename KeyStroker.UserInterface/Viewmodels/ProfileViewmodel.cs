using KeyStroker.Logic.Models;
using KeyStroker.UI.Utils;

namespace KeyStroker.UI.Viewmodels {
    public class ProfileViewmodel : BaseViewmodel {

        private Profile profile;

        public string Name { get => profile.Name; set { profile.Name = value; NotifyPropertyChanged(); } }

        public ProfileViewmodel(Profile profile) {
            this.profile = profile;
        }


    }
}
