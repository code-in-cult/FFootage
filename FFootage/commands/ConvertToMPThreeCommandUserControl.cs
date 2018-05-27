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
    public partial class ConvertToMPThreeCommandUserControl : UserControl, ICommand
    {
        public const string Command = @"-y -i ""{0}"" -codec:a libmp3lame -qscale:a 2 ""{1}""";
        public ConvertToMPThreeCommandUserControl()
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
            /*return InputFile.Insert(InputFile.LastIndexOf("."), "_"
                + String.Format(@"CMp3"));*/
            return InputFile.Substring(0, InputFile.LastIndexOf("."))
            + "_"
            + "CMp3"
            + ".mp3";
        }

        public string getTitle()
        {
            return "Convert To Mp3";
        }

        public int Type()
        {
            return 8;
        }
    }
}
