using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Input;

namespace KeyStroker.Logic
{
    public class ProgrammableButton
    {

        public Key key { get; set; } =
        private bool enabled = true;
        private long repeatAmount = 0;  /* 0 == Infinite */
        private long interval = 100;

        public ProgrammableButton(char key, double time)
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
        // Is this key action enabled
        private bool _isEnabled = true;

        Timer timer;

        public char Button { get { return _button; } private set { } }
        public double Time { get { return _time; } set { _time = value; timer.Interval = value; } }
        public bool IsEnabled { get { return _isEnabled; } 
            set 
            {
                _isEnabled = value;
                if (_timerRunning && value == false)
                    timer.Stop();
            } 
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            SendKeysWrapper.SendSingleKey(_button);
        }
        public void StartTimer() 
        { 
            if(_isEnabled)
            { 
                timer.Start();
                _timerRunning = true;
            }
        }
        public void StopTimer()
        {
            timer.Stop();
            _timerRunning = false;
        }
        public bool TimerRunning() => _timerRunning;
        public override string ToString()
        {
            return String.Format($"{_time} {_button} {_isEnabled}");
        }
    }
}
