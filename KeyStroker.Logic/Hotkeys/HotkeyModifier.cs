
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KeyStroker.Logic.Hotkeys {
    public enum HotkeyModifier : int {

        [Display(Name = "No Modifiers")]
        NOMOD = 0x0000,

        [Display(Name = "Alt")]
        ALT = 0x0001,
        [Display(Name = "Alt + Ctrl")]
        ALT_CTRL = 0x0003,
        [Display(Name = "Alt + Shift")]
        ALT_SHIFT = 0x0005,
        [Display(Name = "Alt + Win")]
        ALT_WIN = 0x0009,

        [Display(Name = "Ctrl")]
        CTRL = 0x0002,
        [Display(Name = "Ctrl + Alt")]
        CTRL_ALT = 0x0003,
        [Display(Name = "Ctrl + Shift")]
        CTRL_SHIFT = 0x0006,
        [Display(Name = "Ctrl + Win")]
        CTRL_WIN = 0x0010,

        [Display(Name = "Shift")]
        SHIFT = 0x0004,
        [Display(Name = "Shift + Alt")]
        SHIFT_ALT = 0x0005,
        [Display(Name = "Shift + Ctrl")]
        SHIFT_CTRL = 0x0006,
        [Display(Name = "Shift + Win")]
        SHIFT_WIN = 0x0012,

        [Display(Name = "Win")]
        WIN = 0x0008,
        [Display(Name = "Win + Alt")]
        WIN_ALT = 0x0009,
        [Display(Name = "Win + Ctrl")]
        WIN_CTRL = 0x0010,
        [Display(Name = "Win + Shift")]
        WIN_SHIFT = 0x0012

    }
}
