
namespace KeyStroker.Logic.Hotkey {

    // LEFT ALT 120 == 0001   
    // CTRL 118 == 0002
    // Shift 116 == 0004
    // WIN xx == 0008

    public enum HotkeyModifier {
        ALT = 0x0001,
        CTRL = 0x0002,
        SHIFT = 0x0004,
        WINKEY = 0x0008
    }
}
