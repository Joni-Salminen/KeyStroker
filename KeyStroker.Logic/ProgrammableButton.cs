using System;
using System.Timers;
using System.Windows.Input;

namespace KeyStroker.Logic
{
    public class ProgrammableButton
    {

        #region UI uses these indirectly
        /* Everything does have well known starting state, so we can use parameteless constructor */
        public Key KeyCode { get; set; } = Key.None;
        public bool IsEnabled { get; set; } = true;
        public long RepeatAmount { get; set; } = 0;
        public long Interval { get; set; } = 100;
        #endregion

        /* Empty constructor */
        public ProgrammableButton() {
            /* Should prop remove from constructor, since now we create new timer object with default Interval always */
            timer = new Timer(Interval);
            timer.Elapsed += Timer_Elapsed;
        }

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
        
        public bool IsTimerEnabled
            { get { return _isEnabled; } 
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
