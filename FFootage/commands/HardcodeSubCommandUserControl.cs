using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FFTool.commands
{
    public partial class HardcodeSubCommandUserControl : UserControl, ICommand
    {
        //public const string Command = @"-y -i ""{0}"" -vf subtitles=""{1}"" ""{2}""";
        //public const string Command = @"-y -i ""{0}"" -filter_complex ""subtitles='{1}',scale=-1:360""";
        public const string Command = @"-y -i ""{0}"" -vf subtitles=""{1}"" ""{2}""";
        //public const string Command = @"-y -i ""{0}"" -sub_charenc CP1252 -i ""{1}"" -map 0:v -map 0:a -c copy -map 1 -c:s:0 mov_text -metadata:s:s:0 language=ger ""{2}""";
        //public const string Command = @"-y -i ""{0}"" -vf ""subtitles='{1}':force_style='Fontsize=24,PrimaryColour=&H0000ff&'"" ""{2}""";
        public HardcodeSubCommandUserControl()
        {
            InitializeComponent();
        }

        public event Action Changed;

        public string InputFile { get; set; }

        public string Settings
        {
            get
            {
                return String.Format(@"File={0}#Subtitle={1}", InputFile, tbSubInput.Text);
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
                    else if (kv[0] == "Subtitle")
                    {
                        tbSubInput.Text = kv[1];
                    }
                }
            }
        }


        public string getCommand()
        {

            string outFileName = getOutFileName();
            string command = String.Format(Command, InputFile
                , tbSubInput.Text.Replace("\\", "/").Replace(":", @"\\:")
                , outFileName);

            return command;
        }

        public string getOutFileName()
        {
            return InputFile.Insert(InputFile.LastIndexOf("."), "_"
                + String.Format(@"HCSub_S{0}", Path.GetFileName(tbSubInput.Text)));
        }

        public string getTitle()
        {
            return "Hardcode Subtitle";
        }

        public int Type()
        {
            return 5;
        }


        private void tbSubInput_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                tbSubInput.Text = files[0];
            }
        }

        private void tbSubInput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tbSubInput_TextChanged(object sender, EventArgs e)
        {
            Changed?.Invoke();
        }
    }
}
