using System;
using System.Linq;


class Num
{
    static void Main(string[] args)
    {
        int[] num = { 9, 3, 4, 5, 6, 7, 8, 14, 10, 11, 12, 1, 2, 20 };

        var rank = from i in num where i<10 orderby i ascending select i;

        foreach(var i in rank ) 
        { 
            Console.WriteLine(i);
        }
    }
}

