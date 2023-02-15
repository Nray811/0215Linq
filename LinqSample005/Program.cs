using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqSample005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            // 這裡的 person1 是單個物件, 也就是 MyData person1
            
            
            var person1 = list.LastOrDefault((x) => x.Age > 35);
            // 因為找不到, 就會跳出例外
            try 
            {
                var person2 = list.Last((x) => x.Age > 50);
                Console.WriteLine($"大於 50 歲的人最後一個被找到的是 : {person2.Name}");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            var person3 = list.SingleOrDefault((x) => x.Name == "Derrick");          
            // 因為找不到, 就會跳出例外
            if (person3 == null)
            {
                //如果是 null 則另行處理
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到 : {person3.Name}  {person3.Age}歲");
            }

            int index = 1;
            var person4 = list.ElementAtOrDefault(index);
            if (person4 == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到索引為 :{index}的人是 {person4.Name}{ person4.Age}");
            }
            string name = "Bro";
            bool result = list.Any((x) => x.Name == name);
            if (result)
            {
                Console.WriteLine($"找到了 :{name}");
            }
            else
            {
                Console.WriteLine($"找不到 :{name}");
            }

            string name1 = "John";
            bool isAllBill = list.All((x) => x.Name == name);
            if (isAllBill)
            {
                Console.WriteLine($"全都是 {name1}");
            }
            else
            {
                Console.WriteLine($"有些人不叫 {name1}");
            }
            bool isAllOverForty = list.All((x) => x.Age >= 40);
            if (isAllOverForty)
            {
                Console.WriteLine("大家都超過 40 歲");
            }
            else
            {
                Console.WriteLine("有人不到 40 歲");
            }

            Console.WriteLine("沒有人在搞");
            // 找出名稱為 Bill 中的最小 Age
            var min = list.Where((x) => x.Name == "Bill").Min((x) => x.Age);
            Console.WriteLine($"所有 Bill 中最小的年齡是 : {min}");
            // 計算名稱為 Bill 的年齡總和
            var total = list.Where((x) => x.Name == "Bill").Sum((x) => x.Age);
            Console.WriteLine($"所有 Bill 的年齡總和是 : {total}");
            var average = list.Where((x) => x.Name == "Bill").Average((x) => x.Age);
            Console.WriteLine($"所有 Bill 的年齡平均是 : {average}");
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
