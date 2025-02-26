using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1 {
    internal class Program {
        static void Main(string[] args) {
            while (Console.ReadLine().ToLower() != "start") {
                if (Console.ReadLine().ToLower() != "stop") break;
                writtenLine = Console.ReadLine();
                Console.WriteLine(writtenLine);
            }
        }

        string writtenLine;

        private static void Listener() {
            while (Console.ReadLine().ToLower() != "start") {
                if (Console.ReadLine().ToLower() != "stop") break;
                writtenLine = Console.ReadLine();
                Console.WriteLine(writtenLine);
            }
        }
    }
}
