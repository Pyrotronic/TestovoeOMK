using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeZavod
{
    public class ConsoleLogger:ICalculatorLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
