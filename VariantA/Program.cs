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
            Console.WriteLine($"Введенная дата: {SomeDate}, день недели: {TheDay}" +
                $", количетсво дней в месяце: {DayInMonth}, день недели через месяц: {AfterMonth}" +
                $", количество дней между текущей датой и введенной: {Between}");
        }
    }
}

