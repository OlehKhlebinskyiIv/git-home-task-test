using System;
using System.Globalization;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            string task1 = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";
            string task2 = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";
            string task3 = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";

            var task1Result = task1.Split(',').Select(x => x.Trim()).Select((x, index) => $"{index + 1}. {x}").Aggregate((x, y)=>x + ", " + y);

            var task2Result = task2.Split(';').Select(x => x.Split(',')).Select(p => new { Name = p[0].Trim(), Data = DateTime.ParseExact(p[1].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture) }).OrderByDescending(x => x.Data);

            var task3Result = task3.Split(',').Select(x => x.Trim()).Select(x => TimeSpan.Parse($"00:{x}")).Aggregate((t1, t2) => t1.Add(t2));

            Console.WriteLine("Task 1");
                
            Console.WriteLine(task1Result);

            Console.WriteLine("Task 2");

            foreach (var item in task2Result)
            {
                Console.WriteLine(item.Data);
            }

            Console.WriteLine("Task 3");
            Console.WriteLine(task3Result);          

            Console.ReadKey();
        }
    }
}
