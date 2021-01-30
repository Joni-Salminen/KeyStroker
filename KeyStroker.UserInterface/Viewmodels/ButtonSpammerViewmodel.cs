using KeyStroker.UI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KeyStroker.UI.Viewmodels
{
    public class ButtonSpammerViewmodel : BaseViewmodel {

        private BindingList<ButtonViewmodel> _keys;
        private ButtonViewmodel _selButton;
        private ButtonViewmodel _editableButton;

        public BindingList<ButtonViewmodel> Buttons { get => _keys; set { _keys = value; } }
        public ButtonViewmodel SelectedButton { get => _selButton; set { _selButton = value; EditableButton = _selButton; NotifyPropertyChanged(); }}
        public ButtonViewmodel EditableButton { get => _editableButton; set { _editableButton = value; NotifyPropertyChanged(); }}

        #region Commands

        private BaseAction _set;
        private BaseAction _remove;
        private BaseAction _add;

        public BaseAction SetNewKey {
            get {
                _set = new BaseAction(StartRecordingKeyPresses);
                    return this._set; 
            }
            set { _set = value; }
        }
        public BaseAction Remove {
            get {
                _remove = new BaseAction(RemoveButton);
                return this._remove;
            }
            set { _remove = value; }
        }
        public BaseAction Add {
            get {
                _add = new BaseAction(AddButton);
                return this._add;
            }
            set { _add = value; }
        }

        #endregion

        /* Public empty constructor */
        public ButtonSpammerViewmodel() {
            InitKeyList();
            EditableButton = new ButtonViewmodel();
        }

        private void InitKeyList() {
            /* Init keys to avoid NullExpection */
            _keys = new BindingList<ButtonViewmodel> {
                /* Allow all changes to the list */
                AllowRemove = true,
                AllowNew = true,
                AllowEdit = true
            };
            /* Register for list changed events */
            _keys.ListChanged += KeysChangedEvent;

            Buttons.Add(new ButtonViewmodel(System.Windows.Input.Key.Enter, false, 100, 10));
            Buttons.Add(new ButtonViewmodel(System.Windows.Input.Key.A, true, 300, 9999999));
            Buttons.Add(new ButtonViewmodel(System.Windows.Input.Key.C, false, 400, 8));
            
        }

        public void StartRecordingKeyPresses() {
            /* Call function to grab next key pressed */   


        }

        public void RemoveButton() {

        }

        public void AddButton() {

        }

        private void KeysChangedEvent(object sender, ListChangedEventArgs e) {

            int _changeIndex = e.NewIndex;

            switch (e.ListChangedType) {

                case ListChangedType.ItemChanged:                    
                    break;
                case ListChangedType.ItemAdded:
                    break;
                case ListChangedType.ItemDeleted:
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.Reset:
                    break;
                /* For every other case just return, since for now we are not interested in those */
                default: return;


            }
        }



    }
}
