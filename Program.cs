using System;

namespace OOP
{
    // the class
    class Program
    {
        // method main
        static void Main(string[] args)
        {
            // object
            Latihan1 MyObject1 = new Latihan1();
            //print value
            Console.WriteLine(MyObject1.brand+" >> "+MyObject1.car);

            //object
            latihan2 MyObject2 = new latihan2();
            //print value
            Console.WriteLine(MyObject2.brand+" >> "+MyObject2.Bike);
            
            Latihan1 MyObject3 = new Latihan1();
            Latihan1 MyObject4 = new latihan2();

            MyObject3.BeliMobil();
            MyObject4.BeliMobil();
        }
    }

}
