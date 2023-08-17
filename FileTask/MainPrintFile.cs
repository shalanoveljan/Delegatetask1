using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTask
{
    internal class MainPrintFile
    {
        public MainPrintFile(Excel excel,Word word,Pdf pdf)
        {
            excel = new Excel();
            word = new Word();
            pdf = new Pdf();
        }
    }
}
