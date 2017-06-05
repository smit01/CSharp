using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0605_ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Console.Write("Please keyin your name: ");
            string s = Console.ReadLine();
            Console.WriteLine("Hello! {0}", s);
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
