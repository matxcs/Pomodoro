using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro
{
    public class Timer
    {
        public Timer() { Duration = 0; DefaultDuration = 0; }
        private int _duration;
        private int _defaultDuration;
        public int Duration { 
            get => _duration;
            set
            {
                if (value < 0) throw new ArgumentException("Duration can't be negative");
                _duration = value;
            }
        }
        public int DefaultDuration
        {
            get => _defaultDuration;
            set
            {
                if (value < 0) throw new ArgumentException("Default duration can't be negative");
                _defaultDuration = value;
            }
        }
        public void Init(int defD) => DefaultDuration = defD;
        public void Reset() => Duration = DefaultDuration;
        public void Start() { }
        public void Stop() { }
    }
}
