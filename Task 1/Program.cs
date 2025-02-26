using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1 {
    internal class Program {
        
        static void Main(string[] args) {
            SaveFile(Listener());
        }

        private static String Listener() {
            String log= "";
            bool write = false;

            // checks when the user wants to start logging
            while (!write) {
                write = (Console.ReadLine().ToLower() == "start");
            }

            // logs while input is not STOP
            while (write) {
                String writtenLine = Console.ReadLine();
                if (writtenLine.ToLower() == "stop") break;

                Console.WriteLine(writtenLine); // output writtenLine
            }

            return log;
        }

        private static void SaveFile(String arg) {
            DateTime today = DateTime.Today;
            string fileName = today.ToString("d");
            string path = $@"../../";

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, fileName))) {
                outputFile.WriteLine(arg);
            }
        }
    }
}
