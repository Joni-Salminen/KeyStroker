using KeyStroker.UI.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeyStroker.UI.Viewmodels
{
    public class KeySpammerViewmodel : BaseViewmodel {


        private BaseAction _set;

        public BaseAction SetKey {
            get {
                _set = new BaseAction(SetKey);
                    return this._set; 
            }
            set { _set = value; }
        }


        /* Public empty constructor */
        public KeySpammerViewmodel() {

        }


        public void SetKey() {
            /* Call function to grab next key pressed */   



        }

    }
}
