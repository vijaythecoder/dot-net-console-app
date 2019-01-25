using System;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont;
            int month;
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            for (int i = 0; i<weekDays.Length; i++)
            {
                Console.Write(weekDays[i] + "     ");
            }
            Console.WriteLine("");
            for (var j = 0; j < 5; j++)
            {
                Console.Write("        ");
            }
            bool firstRow = true;
            for (int i = 1; i < 31; i++)
            {
                if (i%7 == 0 || (firstRow && i+5%7 == 0))
                {
                    firstRow = false;
                    Console.WriteLine(i < 10 ? "0"+i : ""+i);
                } else
                {
                    Console.Write(i < 10 ? "0" + i + "      " : "" + i + "      ");

                }
                Console.Write(firstRow);
            }


            Console.ReadKey();


        }
    }
}
