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
    public partial class CutNRCommandUserControl : UserControl, ICommand
    {
        public const string Command = @"-y -i ""{0}"" -vcodec copy -acodec copy -ss {1:hh\:mm\:ss\.fff} -t {2:hh\:mm\:ss\.fff} ""{3}""";

        public CutNRCommandUserControl()
        {
            InitializeComponent();
        }

        public event Action Changed;

        public string Settings
        {
            get
            {
                return String.Format(@"File={0}#From={1:hh\:mm\:ss\.fff}#Length={2:hh\:mm\:ss\.fff}", InputFile, tseFrom.Value, tseLength.Value);
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
                    else if (kv[0] == "From")
                    {
                        tseFrom.Value = TimeSpan.ParseExact(kv[1], @"hh\:mm\:ss\.fff", System.Globalization.CultureInfo.CurrentCulture);
                    }
                    else if (kv[0] == "Length")
                    {
                        tseLength.Value = TimeSpan.ParseExact(kv[1], @"hh\:mm\:ss\.fff", System.Globalization.CultureInfo.CurrentCulture);
                    }
                }
                //Changed?.Invoke();
            }
        }

        public string InputFile { get; set; }

        public string getCommand()
        {
            TimeSpan tsFrom = tseFrom.Value;
            TimeSpan tsLength = tseLength.Value;
            string outFileName = getOutFileName();
            string command = String.Format(Command, InputFile
                , tsFrom
                , tsLength
                , outFileName);

            return command;
        }

        public string getOutFileName()
        {
            return InputFile.Insert(InputFile.LastIndexOf("."), "_" 
                + String.Format(@"CutNR_F{0:hh\-mm\-ss\-fff}_L{1:hh\-mm\-ss\-fff}", tseFrom.Value, tseLength.Value));
        }


        public string getTitle()
        {
            return "Cut (no recode)";
        }

        public int Type()
        {
            return 0;
        }

        private void tseFrom_ValueChanged()
        {
            tseTo.Value = tseFrom.Value + tseLength.Value;
            Changed?.Invoke();
        }

        private void tseLength_ValueChanged()
        {
            tseTo.Value = tseFrom.Value + tseLength.Value;
            Changed?.Invoke();
        }
    }
}
