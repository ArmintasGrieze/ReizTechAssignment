using System;

namespace ReizTech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

            var hours = program.GetHours();
            var minutes = program.GetMinutes();

            var minutesDegree = 6 * minutes;
            var hourDegree = 30 * hours;

            Console.WriteLine($"Minute's angle degree: {minutesDegree}");
            Console.WriteLine($"Hour's angle degree: {hourDegree}");

            float angle = Math.Abs(hourDegree - minutesDegree);
            Console.WriteLine($"Angle: {angle} degrees.");
        }

        public float GetHours()
        {
            Console.WriteLine("Input hours (12-hour format):");
            var hoursInput = Console.ReadLine();

            if (!float.TryParse(hoursInput, out float hours))
            {
                Console.WriteLine("Incorrect value.");
            }

            if (hours > 12)
            {
                Console.WriteLine("Incorrect value, input cannot exceed 12 hours.");
            }

            return hours;
        }

        public float GetMinutes()
        {
            Console.WriteLine("Input minutes: ");
            var minutesInput = Console.ReadLine();

            if (!float.TryParse(minutesInput, out float minutes))
            {
                Console.WriteLine("Incorrect value.");
            }

            if (minutes > 60)
            {
                Console.WriteLine("Incorrect value, input cannot exceed 60 minutes");
            }

            return minutes;
        }
    }
}