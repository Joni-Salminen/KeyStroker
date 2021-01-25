using System;

namespace KeyStroker.Logic
{
    public class Key
    {
        public Key(char key)
        {
            _button = key;
        }

        // Key to send
        private char _button;
        // Interval to send the key
        private string _time;
        // Last time key was sent
        private string _lastSent;
        
        public char Button { get => _button; private set { } }
        public string Time { get { return _time; } set { _time = value; } }
        public string LastSent { get => _lastSent; private set { } }
        
        // Send Key and also set time when the key was sent last time
        public void SendThis()
        {
            SendKeysWrapper.SendSingleKey(_button);
            _lastSent = DateTime.Now.ToString("hh.mm.ss.ffffff");
        }

        // Perhaps build some date string compare to check if lastTime compared to DateTime.Now > _time
        public bool ShouldSend()
        {
            return false;
        }
    }
}
