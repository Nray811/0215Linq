using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSamples001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mydata> list = CreateList();
            //Query Expression
            //具有IEnumerable可以foreach
            IEnumerable<Mydata> people = 
                from data in list  where data.Name == "Bill" select data;           
            foreach (Mydata person in people)
            {
                Console.WriteLine($"{person.Name}是{person.Age}歲");
            }

            var people1 = list.Where((x) => x.Name == "BIll");
            foreach (Mydata person in people)
            {
                Console.WriteLine($"{person.Name}是{person.Age}歲");
            }

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
