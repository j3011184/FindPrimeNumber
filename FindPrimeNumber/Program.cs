using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeJudgment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("請輸入數字:");
                int Num = Int32.Parse(Console.ReadLine());
                //如果是 0 以及 1 不做
                if (Num > 1)
                {
                    List<int> result = Prime(Num);
                    result.ForEach(i => Console.WriteLine(i));
                }
                else
                    Console.WriteLine("{0}無任何質數", Num);
            }
        }

        /// <summary>質數輸出</summary>
        /// <param name="Num">須找出質數的數字
        private static List<int> Prime(int Num)
        {
            List<int> temps = new List<int>();
            //因為 0,1 不算質數，所以從 2 開始
            for (int i = 2; i <= Num; i++)
            {
                //開根號取最大值+1
                int sqrt = Convert.ToInt32(Math.Sqrt(i) + 1) + 1;
                for (int j = 2; j <= sqrt; j++)
                {
                    //目前讀取的數字與要比對的數字不同
                    if (i != j)
                    {
                        //如果餘數是 0 可以斷定該數字不是質數
                        if (i % j == 0)
                            break;
                        //如果一直到最後都無法整除便可斷定該數字是質數
                        else if (i % j != 0 && j == sqrt)
                            temps.Add(i);
                    }
                }
            }
            return temps;
        }
    }
}