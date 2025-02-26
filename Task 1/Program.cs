using System;
using System.IO;
using System.Reflection;

namespace Task_1 {
    internal class Program {
        
        static void Main(string[] args) {
            SaveFile();
        }

        private static void SaveFile() {
            DateTime today = DateTime.Today;

            string fileName = today.ToString("d").Replace("/",".");
            Console.WriteLine(fileName);

            string docPath = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(docPath);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, $"{fileName}.txt"))) {
                bool write = false;
                outputFile.WriteLine($"Captain's Log\nStartdate {fileName}\n");

                // checks when the user wants to start logging
                while (!write) {
                    write = (Console.ReadLine().ToLower() == "start");
                }

                // logs while input is not STOP
                while (write) {
                    String writtenLine = Console.ReadLine();
                    if (writtenLine.ToLower() == "stop") break;

                    outputFile.WriteLine(writtenLine);
                }

                outputFile.WriteLine("\nJean-Luc Picard");
            }
        }
    }
}