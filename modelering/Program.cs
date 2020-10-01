using System;

namespace modelering
{
    class Program
    {
        static void Main(string[] args)
        {

            jalla moPed = new jalla();

            moPed.x = 40;

            moPed.y = 20;

            moPed.z = 5;
            

            System.Console.WriteLine(moPed.y);

            System.Console.WriteLine(moPed.x - moPed.z);




            Console.WriteLine("Hello World");

            Console.ReadLine();
        }
    }
}
