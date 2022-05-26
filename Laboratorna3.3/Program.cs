using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Month> monthsList = new List<Month>
            {
                new Month("January",31),
                new Month("February",28),
                new Month("March",31),
                new Month("April",30),
                new Month("May",31),
                new Month("June",30),
                new Month("July",31),
                new Month("August",31),
                new Month("September",30),
                new Month("October",31),
                new Month("November",30),
                new Month("December",31)

            };

            var thirtyDays = from d in monthsList where d.countDays == 30 select d;

            foreach (var month in thirtyDays)
            {
                Console.WriteLine(month.monthName + " " + month.countDays);
            }
            Console.ReadLine();
        }
    }
    class Month
    {
        public int countDays;
        public string monthName;

        public Month(string monthName, int countDays)
        {
            this.monthName = monthName;
            this.countDays = countDays;

        }
    }
}
