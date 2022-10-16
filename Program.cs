using System;

namespace PassingReferenceType
{
    class MethodDemo
    {
        //if you pass in a reference type variable,
        //any change made to the variable is valid even after the method ends
        public void PassByReference(int[] b)
        {
            b[0] = 5;
            Console.WriteLine("b[0] inside method = {0}", b[0]);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] b = { 1, 2, 3 };

            MethodDemo obj = new MethodDemo();
            Console.WriteLine("\n" + "Before Method Excution, no change");
            Console.WriteLine("******************************************");
            Console.WriteLine("b before = {0}", b[0]);
            Console.WriteLine("\n" + "Within Method, change is valid ");
            Console.WriteLine("******************************************");
            obj.PassByReference(b);
            Console.WriteLine("\n" + "After Method Excution, change is valid");
            Console.WriteLine("******************************************");
            Console.WriteLine("b after = {0}", b[0]);
            Console.WriteLine("\n" + "1-Therefore a is valid " +
                              "within and  after the method Excution" + "\n" + 
                              "2-The value  of b[0] changes after the method call");
        }
    }
}
