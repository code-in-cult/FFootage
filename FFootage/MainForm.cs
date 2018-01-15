using FFTool.commands;
using FFTool.session;
using FFTool.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFTool
{
    public partial class MainForm : Form
    {
        public const string C_FFMpegBinName = "ffmpeg.exe";
        public const string C_WorkFolderName = "FFTool_Work";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tcCommandInstances.TabPages.Clear();
            try
            {
                EmbeddedResourceExtractor.Extract(C_FFMpegBinName, C_WorkFolderName);
            }
            catch(Exception eee)
            {
                MessageBox.Show("ffmpeg extraction failure: "+eee.Message);
            }

            if (File.Exists(pathOfLastSession()))
            {
                loadSession(pathOfLastSession());
            }
        }

        

        private void addCommandAsTabPage(ICommand com)
        {
            CommandHostUserControl bc = new CommandHostUserControl() { Dock = DockStyle.Fill };
            bc.SetCommandControl(com as Control);
            TabPage tcNew = new TabPage(com.getTitle());
            tcNew.Controls.Add(bc);
            tcCommandInstances.TabPages.Add(tcNew);
            tcCommandInstances.SelectedTab = tcNew;
        }

        private string pathOfLastSession()
        {
            return Path.Combine(Application.StartupPath, C_WorkFolderName, "last.xml");
        }

        private void saveSession(string pathToFile)
        {
            SessionDataSet sds = new SessionDataSet();
           
            foreach(TabPage tc in tcCommandInstances.TabPages)
            {
                var newRow = sds.CommandInstances.NewCommandInstancesRow();
                foreach(Control c in tc.Controls)
                {
                    if(c is CommandHostUserControl)
                    {
                        foreach (Control c2 in (c as CommandHostUserControl).Controls)
                        {
                            if (c2 is Panel)
                            {
                                newRow.Type = (c2.Controls[0] as ICommand).Type();
                                newRow.Settings = (c2.Controls[0] as ICommand).Settings;
                                break;
                            }
                        }
                        break;
                    } 
                }
                sds.CommandInstances.AddCommandInstancesRow(newRow);
            }

            sds.WriteXml(pathToFile);
        }

        private void loadSession(string pathToFile)
        {
            SessionDataSet sds = new SessionDataSet();
            sds.ReadXml(pathToFile);
            
            foreach(var ci in sds.CommandInstances)
            {
                if (ci.Type == new CutNRCommandUserControl().Type())
                {
                    CutNRCommandUserControl cutnr = new CutNRCommandUserControl() { Settings = ci.Settings };
                    addCommandAsTabPage(cutnr);
                }
                else if (ci.Type == new ChangeAudioNRCommandUserControl().Type())
                {
                    ChangeAudioNRCommandUserControl cutnr = new ChangeAudioNRCommandUserControl() { Settings = ci.Settings };
                    addCommandAsTabPage(cutnr);
                }
                else if (ci.Type == new IntToProgCommandUserControl().Type())
                {
                    IntToProgCommandUserControl cutnr = new IntToProgCommandUserControl() { Settings = ci.Settings };
                    addCommandAsTabPage(cutnr);
                }
                else if (ci.Type == new ChangeSpeedCommandUserControl().Type())
                {
                    ChangeSpeedCommandUserControl cutnr = new ChangeSpeedCommandUserControl() { Settings = ci.Settings };
                    addCommandAsTabPage(cutnr);
                }
                else if (ci.Type == new ResizeCommandUserControl().Type())
                {
                    ResizeCommandUserControl cutnr = new ResizeCommandUserControl() { Settings = ci.Settings };
                    addCommandAsTabPage(cutnr);
                }
                else if (ci.Type == new HardcodeSubCommandUserControl().Type())
                {
                    HardcodeSubCommandUserControl cutnr = new HardcodeSubCommandUserControl() { Settings = ci.Settings };
                    addCommandAsTabPage(cutnr);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSession(pathOfLastSession());
        }

        private void btKillAllffmpeg_Click(object sender, EventArgs e)
        {
            foreach(var p in System.Diagnostics.Process.GetProcessesByName("ffmpeg"))
            {
                p.Kill();
            }
        }

        private void btCutNoRecode_Click(object sender, EventArgs e)
        {
            CutNRCommandUserControl cutnr = new CutNRCommandUserControl();
            addCommandAsTabPage(cutnr);
        }
        private void btChangeAudioNoRecode_Click(object sender, EventArgs e)
        {
            ChangeAudioNRCommandUserControl cutnr = new ChangeAudioNRCommandUserControl();
            addCommandAsTabPage(cutnr);
        }
        private void btInterlacedToProgressive_Click(object sender, EventArgs e)
        {
            IntToProgCommandUserControl cutnr = new IntToProgCommandUserControl();
            addCommandAsTabPage(cutnr);
        }

        private void btChangeSpeed_Click(object sender, EventArgs e)
        {
            ChangeSpeedCommandUserControl cutnr = new ChangeSpeedCommandUserControl();
            addCommandAsTabPage(cutnr);
        }

        private void btResize_Click(object sender, EventArgs e)
        {
            ResizeCommandUserControl cutnr = new ResizeCommandUserControl();
            addCommandAsTabPage(cutnr);
        }

        private void btHardcodeSub_Click(object sender, EventArgs e)
        {
            HardcodeSubCommandUserControl cutnr = new HardcodeSubCommandUserControl();
            addCommandAsTabPage(cutnr);
        }
    }
}
