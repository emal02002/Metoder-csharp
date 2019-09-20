using System;

namespace metoder_csharp_InlUpp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radie = 2.4;
            Console.WriteLine("Cirkelns omkrets: " + CirkelOmkrets(radie));
            Console.WriteLine("Cirkelns area: " + CirkelArea(radie));
        }

        static double CirkelOmkrets(double r)
        {
            return (r + r * 3.14);
        }
        static double CirkelArea(double r)
        {
            return (2 * r * 3.14);
        }




    }
}
