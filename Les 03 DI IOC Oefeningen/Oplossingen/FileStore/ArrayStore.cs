using System;
using System.Collections.Generic;
using System.Text;

namespace FileStore
{
    class ArrayStore
    {
        private IPrinter printer;

        public ArrayStore(IPrinter printer)
        {
            this.printer = printer;
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
