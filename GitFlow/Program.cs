using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFlow
{
    class Program
    {
        //this is an hotfix! for release 1.0.1
        public static int doubleint(int i)
        {
            return i * 2;
        }
        public static void featureOne(int i)
        {
            Console.WriteLine("feature 1.3 " + doubleint(i));

        }
        public static void FeatureTwo(string s)
        {
            Console.WriteLine("F2.2 say "+helloer.SayHullow() + s+" nini");
        }
        static void Main(string[] args)
        {
            FeatureTwo("ciao");

            featureOne(0);
        }
    }
}
