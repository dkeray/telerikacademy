using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Strings
{
    static string[] SortArrByElementsLenght(string[] arr)
    {

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = arr[i].Length;
            string minstr = arr[i];
            int minindex = i;
            for (int y = i + 1; y < arr.Length; y++)
            {
                if (arr[y].Length < min)
                {
                    min = arr[y].Length;
                    minstr = arr[y];
                    minindex = y;
                }
            }
            arr[minindex] = arr[i];
            arr[i] = minstr;
        }
        return arr;
    }

    static void Main()
    {

        string[] arr = 
        {
            "deyan",
            "maya",
            "angelina",
            "julia",
            "belgium",
            "usa",
            "brasil", 
        };

        var sort = SortArrByElementsLenght(arr);

      //  var sort = arr.OrderBy(item => item.Length);


        foreach (var item in sort)
	        {
		         Console.WriteLine(item);
	        }

    }
}

