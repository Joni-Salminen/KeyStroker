using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStroker.Logic
{
    public class KeyController
    {
        public List<Key> keyList = new List<Key>();
        private bool _isTimersRunning = false;

        public bool isTimersRunning() => _isTimersRunning;
        public bool registerNewKey(char key, double interval)
        {
            if (interval <= 5)
                return false;
            
            keyList.Add(new Key(key, interval));
            return true;
        }
        public void startAllTimers()
        {
            foreach(Key key in keyList)
            {
                key.StartTimer();
            }
            _isTimersRunning = true;
        }
        public void stopAllTimers()
        {
            foreach(Key key in keyList)
            {
                key.StopTimer();
            }
            _isTimersRunning = false;
        }
    }
}
