using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Singleton_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton firstSingleton = Singleton.Instance;
            Singleton secondSingleton = Singleton.Instance;

            if(firstSingleton == secondSingleton)
            {
                Console.WriteLine("Both instances are the same.");
            }
            else
            {
                Console.WriteLine("Instances are different.");
            }

        }
    }

    public class Singleton
    {
        // Lazy 延遲實體化 第一次要使用時才會 Instance
        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance => lazyInstance.Value;

        private Singleton()
        {
            Trace.WriteLine("Instance");
        }
    }

}
