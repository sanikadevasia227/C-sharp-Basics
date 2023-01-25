using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = ".NET Interview questions";
            object o1 = new string(" Interview question".ToCharArray());

            Console.WriteLine(o == o1);
            Console.WriteLine(o.Equals(o1));
            Console.ReadLine();
        }
    }
}
 