using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //寫出任意三數比大小的結果多種寫法
            int a = 80;
            int b = 70;
            int c = 50;

            //if-else
            Console.WriteLine("if-else");
            if (a > b && a > c && b > c) 
            {
                Console.WriteLine($"{a}>{b}>{c}");
            }
            else if (a > b && a > c && c > b)
            {
                Console.WriteLine($"{a}>{c}>{b}");
            }
            else if (b > a && b > c && a > c)
            {
                Console.WriteLine($"{b}>{a}>{c}");
            }
            else if (b > a && b > c && c > a)
            {
                Console.WriteLine($"{b}>{c}>{a}");
            }
            else if (c > a && c > b && a > b)
            {
                Console.WriteLine($"{c}>{a}>{b}");
            }
            else if (c > a && c > b && b > a)
            {
                Console.WriteLine($"{c}>{b}>{a}");
            }
            
            //三元運算子
            int d = 80;
            int e = 70;
            int f = 50;

            int max = d > e ? d : e; //如果d(80)>e(70)，則最大值max為d(80)，否則為e(70)
            max = max > f ? max : f; //如果最大值大於f，則最大值保持原值，否則為f(50)
            int min = d < e ? d : e; //如果d(80)<e(70)，則最小值max為d(80)，否則為e(70)
            min = min < f ? min : f; //如果最小值小於f，則最小值保持原值，否則為f(50)
            int mid = d + e + f - max - min; //d、e、f的總和減去最大值和最小值，即為中間值。

            Console.WriteLine("--------------------------");
            Console.WriteLine("三元運算子");
            Console.WriteLine($"{max}>{mid}>{min}");

            //使用陣列
            int[] numbers = { 80, 70, 50 };

            Array.Sort(numbers, (x, y) => y.CompareTo(x)); //進行降冪排序

            Console.WriteLine("--------------------------");
            Console.WriteLine("使用陣列");
            Console.WriteLine($"{numbers[0]}>{numbers[1]}>{numbers[2]}");

            //使用自訂函數
            int[] SortNumbers(int g, int h, int i)
            {
                int[] numbers1 = { g, h, i };
                Array.Sort(numbers, (x, y) => y.CompareTo(x)); 
                return numbers; 
            }


            int[] sortedNumbers = SortNumbers(a, b, c);

            Console.WriteLine("--------------------------");
            Console.WriteLine("使用自訂函數");
            Console.WriteLine($"{sortedNumbers[0]}>{sortedNumbers[1]}>{sortedNumbers[2]}");

            //使用LINQ
            int j = 80;
            int k = 70;
            int l = 50;

            var sortedNumbers1 = new[] { j, k, l }.OrderBy(x => x);

            Console.WriteLine("--------------------------");
            Console.WriteLine("使用LINQ");
            Console.WriteLine($"{sortedNumbers.First()}>{sortedNumbers.ElementAt(1)}>{sortedNumbers.Last()}");

            Console.ReadKey();
            // 不論哪個條件成立，最後都會執行這行，會等待使用者按下任何鍵，才會關閉程式
        }
    }
}
