using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logger
{
    public class PrintLog : IPrintLog
    {
        public void ToFile(string message)
        {
            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\log.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(message);
            }
        }

        public void ToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
