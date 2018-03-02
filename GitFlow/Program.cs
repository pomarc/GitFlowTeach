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
            Console.WriteLine("F2.2 say "+helloer.SayHullow() + s+" nini");
        }
        static void Main(string[] args)
        {
            FeatureTwo("ciao");
        }
    }
}
