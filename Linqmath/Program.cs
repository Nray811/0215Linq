using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linqmath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            // 計算 list 中，所有 Age 的總和
            int total = list.Sum((x) => x.Age);
            Console.WriteLine($"年齡的總和為: {total}");
            // 取得 list 中, Age 最小的值
            var minAge = list.Min((x) => x.Age);
            Console.WriteLine($"最小的年齡為 : {minAge}");
            // 取得 list 中, Age 最大的值
            var maxAge = list.Max((x) => x.Age);
            Console.WriteLine($"最大的年齡為 : {maxAge}");
            // 取得 list 中的數量
            //請注意 Count 和 Count() 是不一樣的
            int count = list.Count();
            Console.WriteLine($"list 總個數為 : {count}");
            int countOfBill = list.Count((x) => x.Name == "Bill");
            Console.WriteLine($"list 中的 Bill 總數量為 : {countOfBill}");
            // 取得所有年齡的平均值
            var average = list.Average((x) => x.Age);
            Console.WriteLine($"年齡的平均值為 : {average}");

            var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var list2 = new List<int> { 1, 3, 4, 7, 8, 9 };
            var union = list1.Union(list2);
            Console.WriteLine("聯集的結果為 :");
            foreach (var item in union)
            {
                Console.Write(item);
            }
            var intersect = list1.Intersect(list2);
            Console.WriteLine();
            Console.WriteLine("交集的結果為 :");
            foreach (var item in intersect)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            var aEXb = list1.Except(list2);
            Console.WriteLine("A 差集 B 的結果為 :");
            foreach (var item in aEXb)
            {
                Console.WriteLine(item);
            }
            var bEXa = list2.Except(list1);
            Console.WriteLine("B 差集 A 的結果為: ");
            foreach (var item in bEXa)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var result =  list1.Except(list2).Union(list2.Except(list1)); //
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            var result1 = list1.Union(list2).Except(list1.Intersect(list2)); //
            foreach (var i in result1)
            {
                Console.WriteLine(i);
            }








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
