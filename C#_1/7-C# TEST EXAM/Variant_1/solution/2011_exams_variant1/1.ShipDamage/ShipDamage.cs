using System;

class ShipDamage
{
    static void Main()
    {
        int SX1 = int.Parse(Console.ReadLine());
        int SY1 = int.Parse(Console.ReadLine());
        int SX2 = int.Parse(Console.ReadLine());
        int SY2 = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        int CX1 = int.Parse(Console.ReadLine());
        int CY1 = int.Parse(Console.ReadLine());
        int CX2 = int.Parse(Console.ReadLine());
        int CY2 = int.Parse(Console.ReadLine());
        int CX3 = int.Parse(Console.ReadLine());
        int CY3 = int.Parse(Console.ReadLine());

        int minX = Math.Min(SX1, SX2);
        int maxX = Math.Max(SX1, SX2);
        int minY = Math.Min(SY1, SY2);
        int maxY = Math.Max(SY1, SY2);

        int damage = 0;

        CY1 = 2*H - CY1;
        CY2 = 2*H - CY2;
        CY3 = 2*H - CY3;
        int[] bombX = new int[4];
        int[] bombY = new int[4];
        bombX[1] = CX1;
        bombY[1] = CY1;

        bombX[2] = CX2;
        bombY[2] = CY2;

        bombX[3] = CX3;
        bombY[3] = CY3;

        for (int i = 1; i <= 3; i++)
        {
            if ((bombY[i] == minY || bombY[i] == maxY) && (bombX[i] == minX || bombX[i] == maxX))
            {
                damage += 25;
            }
            if ((bombX[i] == minX || bombX[i] == maxX) && bombY[i] > minY && bombY[i] < maxY)
            {
                damage += 50;
            }
            if ((bombY[i] == minY || bombY[i] == maxY) && bombX[i] > minX && bombX[i] < maxX)
            {
                damage += 50;
            }
            if ((bombX[i] > minX && bombX[i] < maxX) && (bombY[i] > minY && bombY[i] < maxY))
            {
                damage += 100;
            }
        }
        Console.WriteLine(damage+"%");
    }
}