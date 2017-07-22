using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _15th_DAY_MONTH
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Program s = new Program();
            Console.WriteLine("Enter the Year :");
            try
            {
                year = int.Parse(Console.ReadLine());
                s.findday(year);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            Console.ReadLine();
        }
        public void findday(int year)
        {
            int year1 = year,k=0;
            List<DayOfWeek> list = new List<DayOfWeek>();
            if (year > 2020)
                throw new ArgumentOutOfRangeException("'YEAR'\n\n'Enter the YEAR lesser than or equal to 2020'");
            else
            {
                while (year <= 2020)
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        DateTime day15 = new DateTime(year, i, 15);
                        list.Add(day15.DayOfWeek);
                    }
                    year++;
                }
                while (year1 <= 2020 && k<list.Count)
                {
                    Console.WriteLine("\n\nYear: {0}\n______________________________", year1);
                    for (int j = 1; j <= 12; j++)
                    {
                        Console.Write("In {0} 15th day is:-", CultureInfo.CurrentUICulture.DateTimeFormat.MonthNames[j - 1].Substring(0,3));
                        Console.WriteLine(list[k++]);
                    }
                    year1++;
                    Console.WriteLine("______________________________");
                }
            }
        }
    }
}


 