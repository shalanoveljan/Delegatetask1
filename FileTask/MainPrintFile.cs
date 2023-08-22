using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTask
{
    internal class MainPrintFile
    {
         private object _obj;

    public MainPrintFile(object obj)
    {
        _obj = obj;
    }

    public void Print()
    {
        if (_obj is Word)
        {
            ((Word)_obj).Print();
        }
        else if (_obj is Excel)
        {
            ((Excel)_obj).Print();
        }
        else if (_obj is PDF)
        {
            ((PDF)_obj).Print();
        }
    }
}
    }
}
