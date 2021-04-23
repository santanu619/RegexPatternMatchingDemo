using System;

namespace RegexPatternMatchingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            //bool result=pattern.validatePinCode("abc-100-100@.nt.in");
            //bool result = pattern.validatePinCode("400 088");
            //bool result = pattern.validatePinCode("abc.xyz@bridgelabz.co.in");
            bool result = pattern.validatePinCode("mohapatra.santanu123@gmail.com");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
