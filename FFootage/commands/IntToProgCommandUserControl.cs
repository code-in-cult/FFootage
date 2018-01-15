using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFTool.commands
{
    public partial class IntToProgCommandUserControl : UserControl, ICommand
    {
        public const string Command = @"-y -i ""{0}"" -vf yadif=1,format=yuv420p -c:v libx264 ""{1}""";
        public IntToProgCommandUserControl()
        {
            InitializeComponent();
        }

        public string InputFile { get; set; }

        public string Settings
        {
            get
            {
                return String.Format(@"File={0}", InputFile);
            }
            set
            {
                string[] sa = value.Split('#');
                foreach (string kvp in sa)
                {
                    string[] kv = kvp.Split('=');
                    if (kv[0] == "File")
                    {
                        InputFile = kv[1];
                    }
                }
            }
        }

        public event Action Changed;

        public string getCommand()
        {
            string outFileName = getOutFileName();
            string command = String.Format(Command, InputFile
                , outFileName);

            return command;
        }

        public string getOutFileName()
        {
            return InputFile.Insert(InputFile.LastIndexOf("."), "_"
                + String.Format(@"I2P"));
        }

        public string getTitle()
        {
            return "Interlaced To Progressive";
        }

        public int Type()
        {
            return 2;
        }
    }
}
