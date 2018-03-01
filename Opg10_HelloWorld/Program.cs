using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg10_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if(System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }
    }
    enum Køn
    {
        Mand = 0,
        Kvinde = 1
    }
}
