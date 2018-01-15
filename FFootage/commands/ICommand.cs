using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTool.commands
{
    interface ICommand
    {
        string getTitle();
        int Type();
        string getCommand();
        string getOutFileName();

        string Settings { get; set; }
        string InputFile { get; set; }
        event Action Changed;
    }
}
