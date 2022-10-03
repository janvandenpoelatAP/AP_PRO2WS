using System;
using System.Collections.Generic;
using System.Text;

namespace FileStore
{
    class ArrayStore
    {
        private ScreenPrinter printer;

        public ArrayStore()
        {
            this.printer = new ScreenPrinter();
        }

        public void Store(string[] lines)
        {
            var text = "";
            foreach (var line in lines)
            {
                text += line + "\n";
            }
            printer.Print(text);
        }
    }
}
