using System;

namespace Task1_date
{
    internal class Date
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
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
        }

        //добавление месяцев
        public void AddMonths(int months)
        {
            DateTime date = new DateTime(year, month, day).AddMonths(months);
            day = date.Day;
            month = date.Month;
            year = date.Year;
        }

        //добавление лет
        public void AddYears(int years)
        {
            DateTime date = new DateTime(year, month, day).AddYears(years);
            day = date.Day;
            month = date.Month;
            year = date.Year;
        }

        //проверка даты
        public bool CheckDate()
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