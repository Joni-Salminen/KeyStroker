﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KeyStroker.Logic
{
    public class Hotkey
    {
        public Hotkey(Key key, ModifierKeys modifiers)
        {
            _key = key;
            _modifiers = modifiers;
        }

        private Key _key;
        private ModifierKeys _modifiers;

        public uint GetKey()
        {
            return (uint)KeyInterop.VirtualKeyFromKey(_key);
        }

        public uint GetModifiers()
        {
            uint retval = 0x0;

            if (_modifiers == ModifierKeys.Alt)
                retval += (uint)ModifierList.ALT;
            if (_modifiers == ModifierKeys.Control)
                retval += (uint)ModifierList.CTRL;
            if (_modifiers == ModifierKeys.Shift)
                retval += (uint)ModifierKeys.Shift;
            if (_modifiers == ModifierKeys.Windows)
                retval += (uint)ModifierList.WIN;
            return retval;
        }

        public override int GetHashCode()
        {
            return (int)GetKey() * (int)GetModifiers();
        }
    }
}
