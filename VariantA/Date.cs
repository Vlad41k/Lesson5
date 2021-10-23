using System;
using System.Collections.Generic;
using System.Text;

namespace VariantA
{
    class Date
    {
        // Дни недели
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thusday,
            Friday,
            Saturday,
            Sunday
        }
        // Свойства класса
        public DateYear Year { get; }
        public DateMonth Month { get; }
        public DateDay Day { get; }
        // Конструкторы класса
        public Date() {}
        public Date(int day, int month, int year)
        {
            Year = new DateYear(year);
            Month = new DateMonth(month);
            Day = new DateDay(day);
        }
        // Методы класса
        public DayOfWeek GetDayOfWeek() =>  
            new DateTime(DateYear.Year,DateMonth.Month,DateDay.Day).DayOfWeek;  // День недели по заданному числу 
        public int DaysBetween() // Количетсво дней между текущей датой и заданным числом
        {
            DateTime a = new DateTime(DateYear.Year, DateMonth.Month, DateDay.Day);
            DateTime now = DateTime.Now;
            return Math.Abs((now - a).Days);
        } 
        // Встроенные классы
        public class DateYear
        {
            public bool Leap;
            public static int Year { get; set; }
            public DateYear(int year)
            {
                if (year >= 1 && year <= 3000)
                    Year = year;
                else
                    throw new ArgumentException();
                if (year % 4 == 0)// Проверка на високосность года
                    Leap = true;
                else 
                    Leap = false;
            } 
            public override string ToString() => Year.ToString();
        }
        public class DateMonth
        {
            public static int Month { get; set; }
            public DateMonth(int month)
            {
                if (month >= 1 && month <= 12)
                    Month = month;
                else
                    throw new ArgumentException();
            }
            public int getDays(int monthNumber, bool leapYear)
            {
                switch (monthNumber)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        return 31;
                    case 4: case 6: case 9: case 11:
                        return 30;
                    case 2:
                        if (leapYear == true)
                            return 29;
                        else
                            return 28;
                    default:
                        throw new IndexOutOfRangeException();
                }
            } // Получение количества дней в месяце
            public override string ToString() => Month.ToString();
        }
        public class DateDay
        {
            public static int Day { get; set; }
            public DateDay(int day)
            {
                if (day >= 1 && day <= 31)
                    Day = day;
                else
                    throw new ArgumentException();
            }
            public override string ToString() => Day.ToString();
        }
        public static DayOfWeek ValueOf(int index) => 
            (DayOfWeek)((int)(DateTime.Now.DayOfWeek + index) % 7); // День недели через месяц
        public override string ToString() => $"{Day}.{Month}.{Year}";
        public override bool Equals(object obj)
        {
            Date otherDate = obj as Date;
            return otherDate != null ? 
                otherDate.Year.Equals(Year) && 
                otherDate.Month.Equals(Month) && 
                otherDate.Day.Equals(Day) : false;
        }
    }
}
