using System;

namespace Task1
{
    internal class Date
    {
        private int dayNow;
        private int monthNow;
        private int yearNow;

        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public WeekDayEnum weekDay { get; set; }

        public enum WeekDayEnum
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public Date(int day, int month, int year, int weekDay)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.weekDay = CalculateWeekDay(day, month, year);
        }

        public Date(int dayNow, int monthNow, int yearNow)
        {
            this.dayNow = dayNow;
            this.monthNow = monthNow;
            this.yearNow = yearNow;
        }

        //день недели для конкретной даты
        private WeekDayEnum CalculateWeekDay(int day, int month, int year)
        {
            DateTime date = new DateTime(year, month, day);
            return (WeekDayEnum)date.DayOfWeek;
        }

        //кол-во дней в месяце
        public int DaysInMonth()
        {
            return DateTime.DaysInMonth(year, month);
        }

        //добавление дней
        public void AddDays(int days)
        {
            DateTime date = new DateTime(year, month, day).AddDays(days);
            day = date.Day;
            month = date.Month;
            year = date.Year;
            weekDay = (WeekDayEnum)date.DayOfWeek;
        }

        //добавление месяцев
        public void AddMonths(int months)
        {
            DateTime date = new DateTime(year, month, day).AddMonths(months);
            day = date.Day;
            month = date.Month;
            year = date.Year;
            weekDay = (WeekDayEnum)date.DayOfWeek;
        }

        //добавление лет
        public void AddYears(int years)
        {
            DateTime date = new DateTime(year, month, day).AddYears(years);
            day = date.Day;
            month = date.Month;
            year = date.Year;
            weekDay = (WeekDayEnum)date.DayOfWeek;
        }

        //проверка даты
        public bool IsValidDate()
        {
            try
            {
                DateTime date = new DateTime(year, month, day);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}