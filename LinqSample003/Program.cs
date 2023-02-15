using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqSample003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();          
            // 這裡的 person1 是單個物件, 也就是 MyData person1
            var person1 = list.FirstOrDefault((x) => x.Age < 30);
            Console.WriteLine($"小於 37 歲的人第一個被找到的是 : {person1.Name}");
            // 因為找不到, 就會跳出例外
            var person2 = list.First((x) => x.Age < 30);
            Console.WriteLine($"小於 30 歲的人第一個被找到的是 : {person2.Name}");
            Console.ReadLine();
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








