using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFlow
{
    class Program
    {
        public static void featureOne(int i)
        {
            Console.WriteLine("feature 1.1 " + i*2);
        }
        static void Main(string[] args)
        {

            featureOne(0);
        }
    }
}
