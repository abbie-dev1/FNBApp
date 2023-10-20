using fnbLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace BankingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int acc1, acc2, acc3, total;

            //Assign values
            acc1 = 3;
            acc2 = 1;
            acc3 = 8;
            total = acc1 + acc2 + acc3;

            string path = @"E:\Banking\info.txt";
            string data = acc1 + "\t" + "\t" + acc2 + "\t" + acc3 + "\t" + total;

            FileManager obj = new FileManager();
            obj.WriteToFile(path, data);

            //Word Document
            //Open a microsoft doc
            string wordPath = @"E:\Banking\Name.docx";

            dynamic word = new Microsoft.Office.Interop.Word.Application();
            dynamic doc = word.Document.Open(wordPath);

            word.Dispose();
            doc.Dispose();
        }
    }
}
