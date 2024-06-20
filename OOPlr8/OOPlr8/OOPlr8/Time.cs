namespace OOPlr8
{
    class Time
    {
        private readonly int day;
        private readonly int month;
        private readonly int year;
        private readonly int hour;
        private readonly int minute;

        public Time()
        {
            var date = DateTime.Now;
            day = date.Day;
            month = date.Month;
            year = date.Year;
            hour = date.Hour;
            minute = date.Minute;
        }
        public Time(int day, int month, int year, int hour, int minute)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.hour = hour;
            this.minute = minute;
        }
        public int Day { get { return day; } }
        public int Month { get { return month; } }
        public int Year { get { return year; } }
        public int Hour { get { return hour; } }
        public int Minute { get { return minute; } }

        public bool IsWithinRange(Time from, Time to)
        {
            DateTime thisDate = new DateTime(year, month, day, hour, minute, 0);
            DateTime fromDate = new DateTime(from.Year, from.Month, from.Day, from.Hour, from.Minute, 0);
            DateTime toDate = new DateTime(to.Year, to.Month, to.Day, to.Hour, to.Minute, 0);

            return thisDate >= fromDate && thisDate <= toDate;
        }
    }
}
