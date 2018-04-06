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
    public partial class CarPlayerConversionCommandUserControl : UserControl, ICommand
    {
        public const string Command = @"-y -i ""{0}"" -vf scale=480:272 -c:v mpeg4  -vb {1}k -c:a aac -b:a 64k -f segment -segment_time {2} {3}""{4}""";
        public CarPlayerConversionCommandUserControl()
        {
            InitializeComponent();
        }

        public string InputFile { get; set; }

        public string Settings
        {
            get
            {
                return String.Format(@"File={0}#VideoBitrate={1}#SplitSize={2}#NormalizeAudio={3}", InputFile, nudVideoBitrate.Value, nudSplitSize.Value, cbNormalizeAudio.Checked);
            }
            set
            {
                try
                {
                    string[] sa = value.Split('#');
                    foreach (string kvp in sa)
                    {
                        string[] kv = kvp.Split('=');
                        if (kv[0] == "File")
                        {
                            InputFile = kv[1];
                        }
                        else if (kv[0] == "VideoBitrate")
                        {
                            nudVideoBitrate.Value = Int32.Parse(kv[1]);
                        }
                        else if (kv[0] == "SplitSize")
                        {
                            nudSplitSize.Value = Int32.Parse(kv[1]);
                        }
                        else if (kv[0] == "NormalizeAudio")
                        {
                            cbNormalizeAudio.Checked = Boolean.Parse(kv[1]);
                        }
                    }
                }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        public event Action Changed;

        public string getCommand()
        {
            string outFileName = getOutFileName();
            string command = String.Format(new System.Globalization.CultureInfo("en-US"), Command, InputFile
                , nudVideoBitrate.Value
                , (nudSplitSize.Value==0?1000000: nudSplitSize.Value*60)
                , (cbNormalizeAudio.Checked? /*"-filter:a dynaudnorm "*/" -af \"compand=0|0:1|1:-90/-900|-70/-70|-30/-9|0/-3:6:0:0:0\" " : "")
                , outFileName);

            return command;
        }

        public string getOutFileName()
        {
            return InputFile.Substring(0, InputFile.LastIndexOf("."))
                +"_"
                + String.Format(@"CarConv_B{0}_S{1}_N{2}_%02d", nudVideoBitrate.Value, nudSplitSize.Value, cbNormalizeAudio.Checked)
                +".mp4";//here we force the mp4 format
        }

        public string getTitle()
        {
            return "Car Player Conversion";
        }

        public int Type()
        {
            return 6;
        }

        private void nudVideoBitrate_ValueChanged(object sender, EventArgs e)
        {
            //Changed?.Invoke();
            if (Changed != null)
            {
                Changed();
            }
        }

        private void nudSplitSize_ValueChanged(object sender, EventArgs e)
        {
            //Changed?.Invoke();
            if (Changed != null)
            {
                Changed();
            }
        }
    }
}
