using System.Net.Http.Headers;
using System.Windows.Threading;

namespace Pomodoro
{
    public class Timer
    {
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public Timer() { Duration = 0;}
        private uint _duration;
        private uint _remaining;
        public uint Duration { 
            get => _duration;
            set
            {
                if (value < 0) { value = 0; }
                _duration = value;
            }
        }

        public uint Remaining
        {
            get => _remaining;
            set
            {
                if (value < 0) { value = 0; }
                _remaining = value;
            }
        }
        public void Reset() => Remaining = Duration;
        public void Start(uint duration) {
            Duration = duration;
            Remaining = duration;
        }
        public void Stop() { }
    }
}
