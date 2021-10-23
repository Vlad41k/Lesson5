using System;

namespace VariantA
{
    class Program
    {
        static void Main(string[] args)
        {
            Date SomeDate = new Date(10,10,2021);
            var TheDay = SomeDate.GetDayOfWeek();
            var DayInMonth = SomeDate.Month.getDays(Date.DateMonth.Month, SomeDate.Year.Leap);
            var AfterMonth = Date.ValueOf(DayInMonth);
            var Between = SomeDate.DaysBetween();
            Console.WriteLine($"Введенная дата: {SomeDate}\nДень недели: {TheDay}" +
                $"\nКоличетсво дней в месяце: {DayInMonth}\nДень недели через месяц: {AfterMonth}" +
                $"\nКоличество дней между текущей датой и введенной: {Between}");
        }
    }
}

