namespace LeapYear
{
    internal class Program
    {

            static void Main(string[] args)
            {
                int currentYear = DateTime.Now.Year;
                int leapYearsFound = 0;

                Console.WriteLine("Next 20 leap years:");

                while (leapYearsFound < 20)
                {
                    if (IsLeapYear(currentYear))
                    {
                        Console.WriteLine(currentYear);
                        leapYearsFound++;
                    }
                    currentYear++;
                }
            }

            static bool IsLeapYear(int year)
            {
                // A year is a leap year if it is divisible by 4,
                // except for years that are divisible by 100,
                // unless the year is also divisible by 400.
                return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            }
        }

    }

