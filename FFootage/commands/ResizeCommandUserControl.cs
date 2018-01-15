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
    public partial class ResizeCommandUserControl : UserControl, ICommand
    {
        //public const string Command = @"-y -i ""{0}"" -s {1}x{2} ""{3}""";
        public const string Command = @"-y -i ""{0}"" -vf scale={1}:{2} -c:v libx264 -crf 18 -preset veryslow -c:a copy ""{3}""";
        public ResizeCommandUserControl()
        {
            InitializeComponent();
        }

        public string InputFile { get; set; }

        public string Settings
        {
            get
            {
                return String.Format(@"File={0}#W={1}#H={2}", InputFile, nudWidth.Value, nudHeight.Value);
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
                    else if (kv[0] == "W")
                    {
                        nudWidth.Value = Int32.Parse(kv[1]);
                    }
                    else if (kv[0] == "H")
                    {
                        nudHeight.Value = Int32.Parse(kv[1]);
                    }
                }
            }
        }

        public event Action Changed;

        public string getCommand()
        {
            string outFileName = getOutFileName();
            string command = String.Format(Command, InputFile
                , nudWidth.Value
                , nudHeight.Value
                , outFileName);

            return command;
        }

        public string getOutFileName()
        {
            return InputFile.Insert(InputFile.LastIndexOf("."), "_"
                + String.Format(@"Resize_W{0}_H{1}", nudWidth.Value
                , nudHeight.Value));
        }

        public string getTitle()
        {
            return "Resize";
        }

        public int Type()
        {
            return 4;
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke();
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke();
        }
    }
}
