using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFlow
{
    class Program
    {
        public static int doubleint(int i)
        {
            return i +i; //faster!
        }
        public static void featureOne(int i)
        {
            Console.WriteLine("feature 1.3 " + doubleint(i));

        }
        public static void FeatureTwo(string s)
        {
            Console.WriteLine("F2.1 " + s+" nini");
        }

        public static void FeatureThree(bool b)
        {
            Console.WriteLine("F3 " + b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("fixed header");
            FeatureTwo("ciao");

            FeatureThree(true);

            featureOne(0);
            Console.ReadKey();
        }
    }
}
