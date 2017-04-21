namespace DfBAdminToolkit.Common.Utils {

    using System;

    public class TimerUtils {
        private long _startTick;
        private long _endTick;
        private volatile bool _started;

        public TimerUtils() {
            _startTick = 0;
            _endTick = 0;
            _started = false;
        }

        public void Start() {
            if (!_started) {
                _started = true;
                _startTick = DateTime.Now.Ticks;
            }
        }

        public TimeSpan Stop() {
            long diff = 0;
            if (_started) {
                _endTick = DateTime.Now.Ticks;
                diff = _endTick - _startTick;
                _started = false;
            }
            return TimeSpan.FromTicks(diff);
        }

        public static string ToTimeStamp(TimeSpan span) {
            return span.ToString("g");
        }
    }
}