using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToarray
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            var list = CreateList();
            var result1 = list.Where((x) => x.Age > 40).ToList();
            var result2 = list.Where((x) => x.Age > 40).ToArray();
            // 使用 Name 當群組分類的索引鍵，而值資料仍然是 MyData
            var result3 = list.Where((x) => x.Age > 40).ToDictionary((x) => x.Name);
            foreach (var item in result3)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"{item.Value.Name} -- {item.Value.Age}");
            }
            Console.WriteLine("--------------");
            // 使用 Name 當群組分類的索引鍵，而且用 Age 當值資料
            var result4 = list.ToDictionary((x) => x.Name, (y) => y.Age);
            foreach (var item in result4)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }           
             Console.WriteLine();
             Console.WriteLine("Method Expression");
            var result = list.GroupBy((x) => x.City);
            foreach (var item in result)
            {
                Console.WriteLine($"住在 : {item.Key}");
                foreach (var p in item)
                {
                    Console.WriteLine(p.Name);
                }
                Console.WriteLine("--------");
            }
            Console.WriteLine("Query Expression");
            var result5 = from o in list group o by o.City into gp select gp;
            foreach (var item in result5)
            {
                Console.WriteLine($"住在 : {item.Key}");
                foreach (var p in item)
                {
                    Console.WriteLine(p.Name);
                }
                Console.WriteLine("--------");
            }

            Console.ReadLine();
        }
        static List<Mydata> CreateList()
        {
            return new List<Mydata>()
                {
                new Mydata { Name = "Bill", Age = 47 , City = "台北"},
                new Mydata { Name = "John", Age = 37 , City = "台北"},
                new Mydata { Name = "Tom", Age = 48 ,  City = "高雄"},
                new Mydata { Name = "David", Age = 36 , City = "台南"},
                new Mydata { Name = "Jeff" , Age = 87 , City = "台南"},
            };
        }
    }
}
