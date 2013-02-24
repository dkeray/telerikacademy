using System;

class FighterAttack
{
    static void Main()
    {
        int PX1, PY1, PX2, PY2, FX, FY, D;
        PX1 = Int32.Parse(Console.ReadLine());
        PY1 = Int32.Parse(Console.ReadLine());
        PX2 = Int32.Parse(Console.ReadLine());
        PY2 = Int32.Parse(Console.ReadLine());
        FX = Int32.Parse(Console.ReadLine());
        FY = Int32.Parse(Console.ReadLine());
        D = Int32.Parse(Console.ReadLine());
        

        int minX = Math.Min(PX1, PX2);
        int maxX = Math.Max(PX1, PX2);
        int minY = Math.Min(PY1, PY2);
        int maxY = Math.Max(PY1, PY2);

        int FMX = FX + D;
        int FMY = FY;

        int FMupX = FMX;
        int FMupY = FMY + 1;
        int FMdownX = FMX;
        int FMdownY = FMY - 1;
        int FMrightX = FMX + 1;
        int FMrightY = FMY;

        int damage = 0;


        
        if ( FMX >= minX && FMX <= maxX && FMY >= minY && FMY <= maxY)
        {
            damage += 100;
        }
        
        if (FMupX >= minX && FMupX <= maxX && FMupY >= minY && FMupY <=maxY)
        {
            damage += 50;
        }
        if (FMdownX >= minX && FMdownX <= maxX && FMdownY >= minY && FMdownY <= maxY)
        {
            damage += 50;
        }
        if (FMrightX >= minX && FMrightX <= maxX && FMrightY >= minY && FMrightY <= maxY)
        {
            damage += 75;
        }

        Console.WriteLine(damage + "%");
    }
}
