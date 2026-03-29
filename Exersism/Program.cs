namespace Exersism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Lasagna
    {
        // TODO: define the 'ExpectedMinutesInOven()' method
        public static TimeOnly ExpectedMinutesInOven()
        {
            return new TimeOnly(00:40);
        }
        // TODO: define the 'RemainingMinutesInOven()' method

        // TODO: define the 'PreparationTimeInMinutes()' method

        // TODO: define the 'ElapsedTimeInMinutes()' method
    }
    class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            return new int[] { 0, 2, 5, 3, 7, 8, 4 };
        }

        public int Today()
        {
            int todayCount = this.birdsPerDay.LastOrDefault();
            return todayCount;
        }

        public void IncrementTodaysCount()
        {
            int todayCount = this.Today();
            this.birdsPerDay[^1] = ++todayCount;
        }

        public bool HasDayWithoutBirds()
        {
            return Array.Exists(this.birdsPerDay, e => e == 0);
        }

        public int CountForFirstDays(int numberOfDays)
        {
            return this.birdsPerDay.Take(numberOfDays).Sum();
        }

        public int BusyDays()
        {
            return this.birdsPerDay.Count(e => e > 5);
        }
    }

}
