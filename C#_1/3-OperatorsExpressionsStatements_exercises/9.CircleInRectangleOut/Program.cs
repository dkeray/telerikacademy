using System;

class CircleIn
{
    static void Main()
    {
        int xCircle = 1;
        int yCircle = 1;
        int radius = 3;
        int xRec = -1;
        int yRec =  1;
        int widthRec = 6;
        int heightRec = 2;
        Console.Write("Enter x: ");
        int xPoint = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int yPoint = int.Parse(Console.ReadLine());

        bool inCircle = (((xPoint - xCircle) * (xPoint - xCircle)) + ((yPoint - yCircle) * (yPoint - yCircle))) <= (radius * radius);
        Console.WriteLine("The point is in circle? -> {0}",inCircle);
        bool outRec = ((xPoint >= xRec) && (xPoint <= (xRec + widthRec))) && ((yPoint <= yRec) && (yPoint >= (yPoint - heightRec)));
        Console.WriteLine("The point is out of rectangle? -> {0} \n",outRec);
        if ((inCircle == true) & (outRec == false))
        {
            Console.WriteLine("The point within the circle and is out of the rectangle \n\n");   
        }
        else 
        { 
            Console.WriteLine("The assignment in not copleted\n\n"); 
        }
    }
}