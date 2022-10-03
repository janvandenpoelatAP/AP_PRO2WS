using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStore
{
    class FilePrinter : IPrinter
    {
        public void Print(string content)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                outputFile.WriteLine(content);
            }
        }
    }
}
