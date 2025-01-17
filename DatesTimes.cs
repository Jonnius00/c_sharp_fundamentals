using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshExercise1_fundamtionals
{
    internal class DatesTimes
    {
        public static void DatesTimesMain() 
        {
            var datetime = new DateTime(2024, 12, 21);
            var now = DateTime.Now;
            var utcnow = DateTime.UtcNow;

            Console.WriteLine("info from created DateTime.now = " + now);
            Console.WriteLine("\t Hour: " + now.Hour);
            Console.WriteLine("\t Minutes: " + now.Minute);
            Console.WriteLine("\t seconds: " + now.Second + "\n");
            Console.WriteLine( now.ToLongDateString() );
            Console.WriteLine( now.ToShortDateString() );
            Console.WriteLine( now.ToLongTimeString() );
            Console.WriteLine( now.ToShortTimeString() );
            Console.WriteLine(now.ToString() );
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine("\n added 1 day: " + tomorrow);
            Console.WriteLine("sustracted 1 day: " + yesterday);
        }
    }

    internal class TimeSpans
    {
        public static void TimeSpansMain()
        {
            var timespan_by_int = new TimeSpan(1, 2, 3);            
            var timespan_by_static = TimeSpan.FromHours(1);
            Console.WriteLine("\ntimespan by ints: " + timespan_by_int);
            Console.WriteLine("timespan by hours: " + timespan_by_static);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2); // by dots in row !
            var duration = start - end; // negative value ! 
            Console.WriteLine("timespan of 2 minutes: " + duration);

            // Properties
            Console.WriteLine("\nProperties of in the TimeSpan(1,2,3)");
            Console.WriteLine("Only minutes: " + timespan_by_int.Minutes);
            Console.WriteLine("TimeSpan converted fully to minutes: " 
                + timespan_by_int.TotalMinutes);

            Console.WriteLine("\n both DateTime and TimeSpan are IMMUTABLE! but...");
            // Add example
            Console.WriteLine("add 10 minutes to existing TimeSpan(1,2,3): " 
                + timespan_by_int.Add( TimeSpan.FromMinutes(10) ));

            Console.WriteLine("Substauct 10 minutes to existing TimeSpan(1,2,3): "
                    + timespan_by_int.Subtract(TimeSpan.FromMinutes(10)));

            // Explicitly convert to string, f.e. to use as an arg
            Console.WriteLine("TimeSpan explicitly .ToString(): " + timespan_by_int.ToString());

            //PArse from string
            Console.WriteLine("static method .Parse() from str: " + TimeSpan.Parse("01:02:03") );
        }

    }

}