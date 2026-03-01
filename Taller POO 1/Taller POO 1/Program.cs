using System;
using System.Collections.Generic;

namespace LogicConcepts
{
    class Proyecto
    {
        static void Main(string[] args)
        {
            try
            {
                var t1 = new Time();
                var t2 = new Time(14);
                var t3 = new Time(9, 34);
                var t4 = new Time(19, 45, 56);
                var t5 = new Time(23, 3, 45, 678);

                var times = new List<Time> { t1, t2, t3, t4, t5 };

                foreach (Time time in times)
                {
                    Console.WriteLine($"Time: {time}");
                    Console.WriteLine($"\tMilliseconds: {time.ToMilliseconds(),15:N0}");
                    Console.WriteLine($"\tSeconds     : {time.ToSeconds(),15:N0}");
                    Console.WriteLine($"\tMinutes     : {time.ToMinutes(),15:N0}");
                    Console.WriteLine($"\tAdd         : {time.Add(t3)}");
                    Console.WriteLine($"\tIs Other day: {time.IsOtherDay(t4)}");
                    Console.WriteLine();
                }

                var t6 = new Time(45, -7, 90, -87);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }

    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;
        private int milliseconds;

        public Time() : this(0, 0, 0, 0) { }

        public Time(int hours) : this(hours, 0, 0, 0) { }

        public Time(int hours, int minutes) : this(hours, minutes, 0, 0) { }

        public Time(int hours, int minutes, int seconds) : this(hours, minutes, seconds, 0) { }

        public Time(int hours, int minutes, int seconds, int milliseconds)
        {
            if (hours < 0 || hours > 23)
                throw new Exception($"The hour: {hours}, is not valid");

            if (minutes < 0 || minutes > 59)
                throw new Exception("Minutes are not valid");

            if (seconds < 0 || seconds > 59)
                throw new Exception("Seconds are not valid");

            if (milliseconds < 0 || milliseconds > 999)
                throw new Exception("Milliseconds are not valid");

            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            this.milliseconds = milliseconds;
        }

        public override string ToString()
        {
            int h;

            if (hours == 0)
                h = 0;
            else if (hours <= 12)
                h = hours;
            else
                h = hours - 12;

            string tt = hours < 12 ? "AM" : "PM";

            return $"{h:00}:{minutes:00}:{seconds:00}.{milliseconds:000} {tt}";
        }

        public long ToMilliseconds() =>
            hours * 3600000L +
            minutes * 60000L +
            seconds * 1000L +
            milliseconds;

        public long ToSeconds() =>
            hours * 3600L +
            minutes * 60L +
            seconds;

        public long ToMinutes() =>
            hours * 60L + minutes;

        public bool IsOtherDay(Time other) =>
            this.ToMilliseconds() + other.ToMilliseconds()
            >= 24L * 3600000L;

        public Time Add(Time other)
        {
            int ms = milliseconds + other.milliseconds;
            int s = seconds + other.seconds + ms / 1000;
            int m = minutes + other.minutes + s / 60;
            int h = hours + other.hours + m / 60;

            return new Time(h % 24, m % 60, s % 60, ms % 1000);
        }
    }
}
