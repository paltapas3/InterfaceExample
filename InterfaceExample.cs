using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IMyInterface
    {
        void MethodToImplement();//Abstract Method signature.
    }

    class InterfaceExample : IMyInterface
    {
        static void Main(string[] args)
        {
            InterfaceExample obj = new InterfaceExample();
            obj.MethodToImplement();
        }

        public void MethodToImplement()
        {
            //Abstract Method Implementation
            Console.WriteLine("Hello World");
            Console.Read();
        }
    }
}
