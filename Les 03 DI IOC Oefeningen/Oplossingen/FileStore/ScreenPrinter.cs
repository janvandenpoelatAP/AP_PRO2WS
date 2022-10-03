using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStore
{
    class ScreenPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
    }
}
