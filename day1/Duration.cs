using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class Duration
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public int TotalSeconds => Hours * 3600 + Minutes * 60 + Seconds;


        public Duration(int totalSeconds) : this(0, 0, totalSeconds) { }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;

            Minutes += Seconds / 60;
            Seconds %= 60;
            Hours += Minutes / 60;
            Minutes %= 60;
        }

        public override string ToString()
        {
            return $"{(Hours > 0 ? "hours: " + Hours + ", " : "")}" +
                     $"Minutes: {Minutes}, " +
                      $"seconds: {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration d)
            {
                return TotalSeconds == d.TotalSeconds;
            }
            return false;
        }


        public override int GetHashCode() => Hours * Minutes * Seconds;



        public static Duration operator +(Duration d1, Duration d2) => new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        public static Duration operator +(Duration d1, int seconds) => new Duration(d1.Hours, d1.Minutes, d1.Seconds + seconds);



        public static bool operator >(Duration d1, Duration d2) => d1.TotalSeconds > d2.TotalSeconds;
        public static bool operator <(Duration d1, Duration d2) => !(d1 > d2);




        public static bool operator >=(Duration d1, Duration d2) => d1.TotalSeconds >= d2.TotalSeconds;
        public static bool operator <=(Duration d1, Duration d2) => d1.TotalSeconds <= d2.TotalSeconds;


        public static bool operator ==(Duration d1, Duration d2) => d1.TotalSeconds == d2.TotalSeconds;
        public static bool operator !=(Duration d1, Duration d2) => d1.TotalSeconds != d2.TotalSeconds;


        public static Duration operator ++(Duration d) => new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        public static Duration operator --(Duration d) => new Duration(d.Hours, d.Minutes - 1, d.Seconds);




        public static explicit operator DateTime(Duration d) => DateTime.Now.AddSeconds(d.TotalSeconds);

        public static implicit operator bool(Duration d) => d.TotalSeconds != 0;

    }
}
