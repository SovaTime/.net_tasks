using System;

namespace DateApp
{

    public class Date
    {
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

        //день недели для конкретной даты
        private DayOfWeekEnum CalculateWeekDay(int day, int month, int year)
        {
            DateTime date = new DateTime(year, month, day);
            return (WeekDayEnum)date.weekDay;
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
            day = date.day;
            month = date.month;
            year = date.year;
            weekDay = (WeekDayEnum)date.weekDay;
        }

        //добавление месяцев
        public void AddMonths(int months)
        {
            DateTime date = new DateTime(year, month, day).AddMonths(months);
            day = date.day;
            month = date.month;
            year = date.year;
            weekDay = (WeekDayEnum)date.weekDay;
        }

        //добавление лет
        public void AddYears(int years)
        {
            DateTime date = new DateTime(year, month, day).AddYears(years);
            day = date.day;
            month = date.month;
            year = date.year;
            weekDay = (WeekDayEnum)date.weekDay;
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
