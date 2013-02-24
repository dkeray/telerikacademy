//using System;

//public class GsmTest
//{
//    static void Main()
//    {
//        Gsm[] test = new Gsm[3];

//        Display testDisplay = new Display(480, 900);
//        Battery testBattery = new Battery(Battery.Type.NiCd, 10, 10);

//        Gsm firstPhone = new Gsm("test1", "test1", "owner1", 12, testDisplay, testBattery);
//        test[0] = firstPhone;

//        Gsm secondPhone = new Gsm("test2", "test2", "owner2", 14, testDisplay, testBattery );
//        test[1] = secondPhone;

//        Gsm thirdPhone = new Gsm("test3", "test3", "owner3", 1, testDisplay, testBattery);
//        test[2] = thirdPhone;

//        for (int i = 0; i < test.Length; i++)
//        {
//            Console.WriteLine(test[i].ToString());
//        }

//        Console.WriteLine(Gsm.IPhone4S.ToString());
//    }
//}