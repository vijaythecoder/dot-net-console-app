using System;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app shows you the selected month with days of current year.");
            Console.WriteLine("Select the month in three letter format(eg jan or sep)");

            String ch = Console.ReadLine();
            Program program = new Program();
            switch (ch)
            {
                case "jan":
                    program.printDates(3, 31);
                    break;
                case "feb":
                    program.printDates(5, 28);
                    break;
                case "mar":
                    program.printDates(5, 31);
                    break;
                case "apr":
                    program.printDates(1, 30);
                    break;
                case "may":
                    program.printDates(3, 31);
                    break;
                case "jun":
                    program.printDates(6, 30);
                    break;
                case "jul":
                    program.printDates(2, 31);
                    break;
                case "aug":
                    program.printDates(4, 31);
                    break;
                case "sep":
                    program.printDates(8, 30);
                    break;
                case "oct":
                    program.printDates(2, 31);
                    break;
                case "nov":
                    program.printDates(5, 30);
                    break;
                case "dec":
                    program.printDates(1, 31);
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
            Console.ReadKey();


        }

        public void printDates (int startDay, int numberOfDays)
        {
            Console.WriteLine("");
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.Write(weekDays[i] + "     ");
            }
            Console.WriteLine("");

            for (var j = 0; j < startDay; j++)
            {
                Console.Write("        ");
            }

            for (int i = 1; i <= numberOfDays; i++)
            {
                if ((i + startDay) % 7 == 0)
                {
                    Console.WriteLine(i < 10 ? "0" + i : "" + i);
                }
                else
                {
                    Console.Write(i < 10 ? "0" + i + "      " : "" + i + "      ");

                }

            }
        }
    }
}
