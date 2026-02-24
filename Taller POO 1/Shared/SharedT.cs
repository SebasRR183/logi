using System;

namespace SharedT
{
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;
        private int milliseconds;

        public Time()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
            milliseconds = 0;
        }

        public Time(int hours)
        {
            if (hours < 0 || hours > 23)
                throw new Exception("Hora inválida");

            this.hours = hours;
            minutes = 0;
            seconds = 0;
            milliseconds = 0;
        }

        public Time(int hours, int minutes)
        {
            if (hours < 0 || hours > 23 ||
                minutes < 0 || minutes > 59)
                throw new Exception("Hora inválida");

            this.hours = hours;
            this.minutes = minutes;
            seconds = 0;
            milliseconds = 0;
        }

        public Time(int hours, int minutes, int seconds)
        {
            if (hours < 0 || hours > 23 ||
                minutes < 0 || minutes > 59 ||
                seconds < 0 || seconds > 59)
                throw new Exception("Hora inválida");

            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            milliseconds = 0;
        }

        public Time(int hours, int minutes, int seconds, int milliseconds)
        {
            if (hours < 0 || hours > 23 ||
                minutes < 0 || minutes > 59 ||
                seconds < 0 || seconds > 59 ||
                milliseconds < 0 || milliseconds > 999)
                throw new Exception("Hora inválida");

            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            this.milliseconds = milliseconds;
        }

        public override string ToString()
        {
            int h = hours % 12;
            if (h == 0) h = 12;

            string tt = hours < 12 ? "AM" : "PM";

            return $"{h:00}:{minutes:00}:{seconds:00}.{milliseconds:000} {tt}";
        }

        public long ToMilliseconds()
        {
            return hours * 3600000L +
                   minutes * 60000L +
                   seconds * 1000L +
                   milliseconds;
        }

        public long ToSeconds()
        {
            return hours * 3600L +
                   minutes * 60L +
                   seconds;
        }

        public long ToMinutes()
        {
            return hours * 60L + minutes;
        }

        public bool IsOtherDay(Time other)
        {
            return this.ToMilliseconds() + other.ToMilliseconds()
                   >= 24L * 3600000L;
        }

        public Time Add(Time other)
        {
            int ms = milliseconds + other.milliseconds;
            int s = seconds + other.seconds + ms / 1000;
            int m = minutes + other.minutes + s / 60;
            int h = hours + other.hours + m / 60;

            return new Time(
                h % 24,
                m % 60,
                s % 60,
                ms % 1000
            );
        }
    }
}}
