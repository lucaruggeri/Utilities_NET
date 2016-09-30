using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Utilities
{
    static public class Logging
    {
        public static void StartLog()
        {
            string path = @"C:\MyLog\";
            string fileName = "Log001.txt";

            using (StreamWriter w = File.AppendText(path + fileName))
            {
                LogBeginning("START", w);
            }

            using (StreamReader r = File.OpenText(path + fileName))
            {
                DumpLog(r);
            }
        }

        private static string GetLastLogFile()
        {
            return @"C:\MyLog\Log001.txt";
        }

        private static void LogBeginning(string logMessage, TextWriter w)
        {
            w.WriteLine();
            w.WriteLine();
            w.WriteLine("This is a log: ");
            w.WriteLine("-------------------------------------------------------------------------");
        }

        public static void Write(string logMessage)
        {
            using (StreamWriter w = File.AppendText(GetLastLogFile()))
            {
                w.Write("---");
                w.Write(" ");
                w.Write(DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString());
                w.Write(" ");
                w.WriteLine(logMessage);
            }
        }

        private static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
