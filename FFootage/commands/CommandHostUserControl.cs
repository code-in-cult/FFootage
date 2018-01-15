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
using FFTool.tools;

namespace FFTool.commands
{
    public partial class CommandHostUserControl : UserControl
    {
        private ICommand command;
        public CommandHostUserControl()
        {
            InitializeComponent();
        }

        public void SetCommandControl(Control commandControl)
        {
            pCommand.Controls.Add(commandControl);
            command = (ICommand)commandControl;
            command.Changed += () => {lOutput.Text = "?"; };
            tbInput.Text = command.InputFile;
        }

        private void tbInput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tbInput_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                tbInput.Text = files[0];
            }
        }


        private void btStart_Click(object sender, EventArgs e)
        {
            lOutput.Text = "?";

            FFMpegRunner runner = new FFMpegRunner();
            runner.OutputDataReceived += (s) =>
                {
                    this.Invoke(new Action(() =>
                    {
                        tbLog.AppendText("\r\n" + s);
                    }));
                };
            runner.Exited += () =>
                {
                    this.Invoke(new Action(() =>
                    {
                        lOutput.Text = "Done: " + command.getOutFileName();
                    }));
                };

            string cmd = command.getCommand();
            tbLog.AppendText("\r\nCommand to execute: " + cmd);
            runner.Start(Path.Combine(Application.StartupPath, MainForm.C_WorkFolderName, MainForm.C_FFMpegBinName), cmd);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            ((this.Parent as TabPage).Parent as TabControl).TabPages.Remove((this.Parent as TabPage));
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            command.InputFile = tbInput.Text;
        }
    }
}
