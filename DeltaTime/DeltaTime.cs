using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Delta Time - Calculate time difference between given pair of time values
    
    https://www.codeeval.com/open_challenges/166/

    Author: Tudor Laptes
*/
namespace DeltaTime
{
    class DeltaTime
    {
        static void Main(string[] args)
        {
            //Take input variables from console
            Console.WriteLine("Please enter start time (HH:MM:SS format):");
            String start = Console.ReadLine();
            Console.WriteLine("Please enter end time (HH:MM:SS format):");
            String end = Console.ReadLine();
            //Output properly formatted time difference between given input variables
            formatTime(Math.Abs((calcTime(end) - calcTime(start))));
        }

        /*
        Function that takes an input string and outputs an int variable that holds
        the total number of seconds calculated from given input
        */
        public static int calcTime(String q)
        {
            int sum = 0, j = q.Split(':').Length-1;
            for(int i=0; i<q.Split(':').Length; i++)
            {
                sum += Int32.Parse(q.Split(':')[i]) * (Int32)Math.Pow(60, j);
                j--;
            }
            return sum;
        }
        /*
        Function that outputs number of hours, minutes, and seconds calculated from
        given integer input (to be used with calcTime function from above)
        */
        public static void formatTime(int q)
        {
            int h, m, s = 0;
            h = q / 3600;
            m = (q % 3600) / 60;
            s = (q % 3600) % 60;
            Console.WriteLine("Delta time:");
            Console.WriteLine(h + " hours, " + m + " minutes, " + s + " seconds.");
            Console.WriteLine(String.Format("{0:00}", h) + ":" + String.Format("{0:00}", m) + ":" + String.Format("{0:00}", s));
        }
    }
}
