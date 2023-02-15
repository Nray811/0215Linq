﻿using System;
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