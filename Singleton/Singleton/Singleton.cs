using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static int count = 0;
        
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(()=>new Singleton());

        public static Singleton Instance
        {
            get
            {

                return _instance.Value;
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine("Count " + count);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
