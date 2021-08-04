using System;

namespace GTIinsight.Shared
{
    public record Period(int Year, int Month)
    {
        public int Value = (Year * 100) + Month;
        public DateTime ToDateTime() => new(Year, Month, 1);

        public string[] Months = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        public override string ToString()
        {
            return $"{Months[Month-1]}-{Year}";
        }
    }
}