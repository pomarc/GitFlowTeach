using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFlow
{
    class Program
    {
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
            FeatureTwo("ciao");

            FeatureThree(true);
        }
    }
}
