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
    public partial class ChangeSpeedCommandUserControl : UserControl, ICommand
    {
        public const string Command = @"-y -i ""{0}"" -r {1} -vf ""setpts=({2:0.0}/1)*PTS"" ""{3}""";
        public ChangeSpeedCommandUserControl()
        {
            InitializeComponent();
        }

        public string InputFile { get; set; }

        public string Settings
        {
            get
            {
                return String.Format(@"File={0}#SpeedDivide={1:0.0}#FPS={2}", InputFile, nudSpeedDivide.Value, nudOutputFrameRate.Value);
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
                        else if (kv[0] == "SpeedDivide")
                        {
                            nudSpeedDivide.Value = Decimal.Parse(kv[1]);
                        }
                        else if (kv[0] == "FPS")
                        {
                            nudOutputFrameRate.Value = Int32.Parse(kv[1]);
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
                , (int)nudOutputFrameRate.Value
                , nudSpeedDivide.Value
                , outFileName);

            return command;
        }

        public string getOutFileName()
        {
            return InputFile.Insert(InputFile.LastIndexOf("."), "_"
                + String.Format(@"ChgSpeed_D{0:0.0}_FPS{1}", nudSpeedDivide.Value, nudOutputFrameRate.Value));
        }

        public string getTitle()
        {
            return "Change Speed";
        }

        public int Type()
        {
            return 3;
        }

        private void nudSpeedDivide_ValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke();
        }

        private void nudOutputFrameRate_ValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke();
        }
    }
}
