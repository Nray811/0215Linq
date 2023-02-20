using Linqorderby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linqorderby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method Expression
            //var list = CreateList();
            //var order1 = list.OrderBy((x) => x.Age);
            //Console.WriteLine("order1");
            //Display(order1);
            //var order2 = list.OrderByDescending((x) => x.Age);
            //Console.WriteLine("order2");
            //Display(order2);
            //var order3 = list.OrderBy((x) => x.Name).ThenBy((x) => x.Age);
            //Console.WriteLine("order3");
            //Display(order3);
            //var order4 = list.OrderBy((x) => x.Name).ThenByDescending((x) => x.Age);
            //Console.WriteLine("order4");
            //Display(order4);

            //Query Expression
            var list = CreateList();
            var order1 =
            from o in list
            orderby o.Name, o.Age
            select o;
            Display(order1);
            var order2 =
            from o in list
            orderby o.Name descending, o.Age descending
            select o;
            Display(order2);

            Console.ReadLine();


        }
        static void Display(IOrderedEnumerable<Mydata> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item.Name + " : " + item.Age);
            }
            Console.WriteLine("-------------");
        }

        static List<Mydata> CreateList()
        {
            return new List<Mydata>()
                {
                new Mydata { Name = "Bill", Age = 47 },
                new Mydata { Name = "John", Age = 37 },
                new Mydata { Name = "Tom", Age = 48 },
                new Mydata { Name = "David", Age = 36 },
                new Mydata { Name = "Bill", Age = 35 },
            };
        }

    }
}
