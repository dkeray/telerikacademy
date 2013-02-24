using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter value of unsigned integer n: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

    //  Variant 1
        uint bit345 = (n & (7 << 3)); // take 3,4,5 bits togather
        uint bit242526 = (n & (7 << 24)); // take 24,25,26 bits togather
        bit345 = bit345 << 21;
        bit242526 = bit242526 >> 21;

        uint result = n;
        n = (uint)(n & (~(7 << 3)));   // set bit 3,4,5 to 0
        result = (uint)(result & (~(7 << 21))); // set bit 24,25,26 to 0
        result = n | bit345;  // Logical OR to change 3,4,5 to 24,25,26
        result = result | bit242526; // Logical OR to change 24,25,26 to 3,4,5

        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine(result);
        
        
        
        
    //  Variant 2
        //uint bit3 = (n & (1 << 3)) >> 3;
        //uint bit4 = (n & (1 << 4)) >> 4;
        //uint bit5 = (n & (1 << 5)) >> 5;
        //uint bit24 = (n & (1 << 24)) >> 24;
        //uint bit25 = (n & (1 << 25)) >> 25;
        //uint bit26 = (n & (1 << 26)) >> 26;
        //uint result = n;

        //if (bit3 == 0)
        //{
        //    result = (uint)(n & (~(1 << 24)));
        //}
        //else
        //{
        //    result = (uint)(result | (1 << 24));
        //}

        //if (bit4 == 0)
        //{
        //    result = (uint)(result & (~(1 << 25)));
        //}
        //else
        //{
        //    result = (uint)(result | (1 << 25));
        //}

        //if (bit5 == 0)
        //{
        //    result = (uint)(result & (~(1 << 26)));
        //}
        //else
        //{
        //    result = (uint)(result | (1 << 26));
        //}

        //if (bit24 == 0)
        //{
        //    result = (uint)(result & (~(1 << 3)));
        //}
        //else
        //{
        //    result = (uint)(result | (1 << 3));
        //}

        //if (bit25 == 0)
        //{
        //    result = (uint)(result & (~(1 << 4)));
        //}
        //else
        //{
        //    result = (uint)(result | (1 << 4));
        //}

        //if (bit26 == 0)
        //{
        //    result = (uint)(result & (~(1 << 5)));
        //}
        //else
        //{
        //    result = (uint)(result | (1 << 5));
        //}

        //Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        //Console.WriteLine(result);
    }
}