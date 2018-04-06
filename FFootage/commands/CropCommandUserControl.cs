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
    public partial class CropCommandUserControl : UserControl, ICommand
    {
        public const string Command = @"-y -i ""{0}"" -filter:v ""crop={1}:{2}:{3}:{4}"" ""{5}""";

        public CropCommandUserControl()
        {
            InitializeComponent();
        }

        public event Action Changed;

        public string Settings
        {
            get
            {
                return String.Format(@"File={0}#Width={1}#Height={2}#X={3}#Y={4}", InputFile, nudWidth.Value, nudHeight.Value, nudX.Value, nudY.Value);
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
                    else if (kv[0] == "Width")
                    {
                        nudWidth.Value = Int32.Parse(kv[1]);
                    }
                    else if (kv[0] == "Height")
                    {
                        nudHeight.Value = Int32.Parse(kv[1]);
                    }
                    else if (kv[0] == "X")
                    {
                        nudX.Value = Int32.Parse(kv[1]);
                    }
                    else if (kv[0] == "Y")
                    {
                        nudY.Value = Int32.Parse(kv[1]);
                    }
                }
                //Changed?.Invoke();
            }
        }

        public string InputFile { get; set; }

        public string getCommand()
        {
            int w = (int)nudWidth.Value;
            int h = (int)nudHeight.Value;
            int x = (int)nudX.Value;
            int y = (int)nudY.Value;
            string outFileName = getOutFileName();
            string command = String.Format(Command, InputFile
                , w
                , h
                , x
                , y
                , outFileName);

            return command;
        }

        public string getOutFileName()
        {
            return InputFile.Insert(InputFile.LastIndexOf("."), "_" 
                + String.Format(@"Crop_W{0}_H{1}_X{2}_Y{3}", nudWidth.Value, nudHeight.Value, nudX.Value, nudY.Value));
        }


        public string getTitle()
        {
            return "Crop";
        }

        public int Type()
        {
            return 7;
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke();
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke();
        }

        private void nudX_ValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke();
        }

        private void nudY_ValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke();
        }
    }
}
