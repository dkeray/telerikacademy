using System;
using System.Collections.Generic;
class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string num = "";
        for (int i = 1; i <= n; i++)
        {
            long temp = long.Parse(Console.ReadLine());
            num += Convert.ToString(temp, 2);
        }
    // Console.WriteLine(num);
       int count = 0;

       string tempS = num;
       char cbit, lastbit = '3';
       int len = 0;
       for (int i = 0; i < tempS.Length; i++)
       {
           cbit = tempS[i];
           if (cbit == lastbit)
           {
               len++;
           }
           else
           {
               if (len == k)
               {
                   count++;

               }
               len = 1;
           }
           lastbit = cbit;
       }
       if (len == k)
       {
           count++;

       }
 


       //tempS = num;
       //while (true)
       //{
       //    //      Console.WriteLine(tempS);
       //    string text = new string('0', k);
       //    if (tempS.Length-1 < k) break;
       //    int tempStart1 = tempS.IndexOf(text) + k;
       //    if (tempStart1 != tempS.Length)
       //        if (Convert.ToInt32(tempS[tempStart1]) == '1')
       //            count++;
       //    tempS = tempS.Substring(tempStart1, tempS.Length - tempStart1);
       //    //      Console.WriteLine(tempS);
       //}

  Console.WriteLine(count);



  List<int> l = new List<int>();
        


    }
}

