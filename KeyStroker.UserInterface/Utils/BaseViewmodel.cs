using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KeyStroker.UI.Utils
{
    public abstract class BaseViewmodel : INotifyPropertyChanged {

        /* Notify property changed implementation for data binding  */
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null) {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null) {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
