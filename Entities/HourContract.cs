

namespace Course.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue(double valuePerHour, int hours)
        {
            ValuePerHour = valuePerHour;
            Hours = hours;
            return valuePerHour * hours;
        }
    }
}
