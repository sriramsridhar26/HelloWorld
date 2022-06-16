using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "dd/mm/yyyy";
            List<interest> list = new List<interest>();
            int principal = Convert.ToInt32((Console.ReadLine()));
            double cappintr = Convert.ToDouble(Console.ReadLine());
            int n= Convert.ToInt32((Console.ReadLine()));
            
            for(int i = 0; i < n; i++)
            {
                list.Add(new interest{ start = DateTime.ParseExact(Console.ReadLine(), pattern, null).ToOADate() + 2415018.5,
                                       end = DateTime.ParseExact(Console.ReadLine(), pattern, null).ToOADate() + 2415018.5,
                                       cond = (Console.ReadLine().Split(' ').Select(int.Parse).ToArray())});
            }
            int maxconds = list.Max(x => x.cond.Max());
            //Console.WriteLine(maxconds);
            int[] condIntrsts = (Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
        }
    }

}
