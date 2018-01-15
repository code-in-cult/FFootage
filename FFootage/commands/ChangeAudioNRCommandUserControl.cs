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
    public partial class ChangeAudioNRCommandUserControl : UserControl, ICommand
    {
        public const string Command = @"-y -i ""{0}"" -i ""{1}"" -vcodec copy -acodec copy -map 0:0 -map 1:0 ""{2}""";
        public ChangeAudioNRCommandUserControl()
        {
            InitializeComponent();
        }

        public event Action Changed;

        public string InputFile { get; set; }

        public string Settings
        {
            get
            {
                return String.Format(@"File={0}#Audio={1}", InputFile, tbAudioInput.Text);
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
                    else if (kv[0] == "Audio")
                    {
                        tbAudioInput.Text = kv[1];
                    }
                }
            }
        }


        public string getCommand()
        {

            string outFileName = getOutFileName();
            string command = String.Format(Command, InputFile
                , tbAudioInput.Text
                , outFileName);

            return command;
        }

        public string getOutFileName()
        {
            return InputFile.Insert(InputFile.LastIndexOf("."), "_"
                + String.Format(@"ChAuNR_A{0}", Path.GetFileName(tbAudioInput.Text)));
        }

        public string getTitle()
        {
            return "Change Audio (no recode)";
        }

        public int Type()
        {
            return 1;
        }

        private void tbAudioInput_TextChanged(object sender, EventArgs e)
        {
            Changed?.Invoke();
        }

        private void tbAudioInput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tbAudioInput_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                tbAudioInput.Text = files[0];
            }
        }
    }
}
