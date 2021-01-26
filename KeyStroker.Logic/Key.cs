using System;
using System.Collections.Generic;
using System.Timers;

namespace KeyStroker.Logic
{
    public class Key
    {
        public Key(char key, double time)
        {
            timer = new Timer(time);

            _button = key;
            _time = time;

            timer.Elapsed += Timer_Elapsed;

            timer.Interval = time;
            timer.AutoReset = true;
        }

        // Key to send
        private char _button;
        // Interval to send the key
        private double _time;
        // Is timer running
        private bool _timerRunning = false;

        Timer timer;

        public char Button { get { return _button; } private set { } }
        public double Time { get { return _time; } set { _time = value; timer.Interval = value; } }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            SendKeysWrapper.SendSingleKey(_button);
        }
        public void StartTimer() 
        { 
            timer.Start();
            _timerRunning = true;
        }
        public void StopTimer()
        {
            timer.Stop();
            _timerRunning = false;
        }
        public bool TimerRunning() => _timerRunning;
    }
}
