using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDI
{
    public class ConsoleMessageWriter:IMessageWrite
    {
        public void PrintMessage()
        {
            Console.WriteLine("@DI");
        }
    }
}
