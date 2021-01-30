using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStroker.Logic
{
    public class KeyController
    {
        public List<ProgrammableButton> keyList = new List<ProgrammableButton>();
        private bool _isTimersRunning = false;

        public bool isTimersRunning() => _isTimersRunning;
        public bool registerNewKey(char key, double interval)
        {
            if (interval <= 5)
                return false;
            
            keyList.Add(new ProgrammableButton(key, interval));
            return true;
        }
        public void startAllTimers()
        {
            foreach(ProgrammableButton key in keyList)
            {
                key.StartTimer();
            }
            _isTimersRunning = true;
        }
        public void stopAllTimers()
        {
            foreach(ProgrammableButton key in keyList)
            {
                key.StopTimer();
            }
            _isTimersRunning = false;
        }
    }
}
