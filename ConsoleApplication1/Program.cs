using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            lista.Add(1);
            lista.Add(5);
            lista.Add(15);
            lista.Add(151);

            Console.WriteLine("\nExists: Part with Id=1: {0}", lista.Exists(x=>x==152));
        }
    }
}
