using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logger
{
    public interface IPrintLog
    {
        void ToConsole(string message);

        void ToFile(string message);
    }
}
