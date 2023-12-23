namespace Practice_3
{
    internal class Clock
    {
        int _Seconds;
        int _Minutes;
        int _Hours;

        public int Seconds
        {
            get
            {
                return _Seconds;
            }
            set
            {
                if (value >= 0 && value < 60)
                    _Seconds = value;
            }
        }

        public int Minutes
        {
            get
            {
                return _Minutes;
            }
            set
            {
                if (value >= 0 && value < 60)
                    _Minutes = value;
            }
        }

        public int Hours
        {
            get
            {
                return _Hours;
            }
            set
            {
                if (value >= 0 && value < 24)
                    _Hours = value;
            }
        }

        public void AddSecond()
        {
            _Seconds++;
            CheckSeconds();
        }

        public void AddMinute()
        {
            _Minutes++;
            CheckMinutes();
        }

        public void AddHour()
        {
            _Hours++;
            CheckHours();
        }

        public void SubtractSecond()
        {
            _Seconds--;
            CheckSeconds();
        }

        public void SubtractMinute()
        {
            _Minutes--;
            CheckMinutes();
        }

        public void SubtractHour()
        {
            _Hours--;
            CheckHours();
        }

        private void CheckSeconds()
        {
            if (_Seconds == 60)
            {
                _Seconds = 0;
                _Minutes++;
                CheckMinutes();
            }
            else if (_Seconds < 0)
            {
                _Seconds = 59;
                _Minutes--;
                CheckMinutes();
            }
        }

        private void CheckMinutes()
        {
            if (_Minutes == 60)
            {
                _Minutes = 0;
                _Hours++;
                CheckHours();
            }
            else if (_Minutes < 0)
            {
                _Minutes = 59;
                _Hours--;
                CheckHours();
            }
        }

        private void CheckHours()
        {
            if (_Hours == 24)
            {
                _Hours = 0;
            }
            else if (_Hours < 0)
            {
                _Hours = 23;
            }
        }

        public void GetCurrentTime()
        {
            string hours = _Hours.ToString();
            string minutes = _Minutes.ToString();
            string seconds = _Seconds.ToString();
            if (hours.Length == 1)
            {
                hours = "0" + hours;
            }
            if (minutes.Length == 1)
            {
                minutes = "0" + minutes;
            }
            if (seconds.Length == 1)
            {
                seconds = "0" + seconds;
            }
            Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
        }

    }
}
