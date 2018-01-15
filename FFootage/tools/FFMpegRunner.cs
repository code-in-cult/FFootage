using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FFTool.tools
{
    class FFMpegRunner
    {
        public Action<string> OutputDataReceived;
        public Action Exited;

        public void Start(string pathToFFMpeg, string lcArgs)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = pathToFFMpeg;
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = lcArgs;

            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            Process exeProcess = new Process();
            exeProcess.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            exeProcess.ErrorDataReceived += new DataReceivedEventHandler(ErrorHandler);
            exeProcess.StartInfo = startInfo;
            exeProcess.Exited += (s, e) =>
            {
                if (Exited != null)
                {
                    Exited();
                }
            };

            Thread tExitWatcher = new Thread(new ThreadStart(() =>
            {
                while (!exeProcess.HasExited)
                {
                    Thread.Sleep(100);
                    //exeProcess.Refresh();
                }
                if (Exited != null)
                {
                    Exited();
                }
            }));

            exeProcess.Start();
            exeProcess.BeginOutputReadLine();
            exeProcess.BeginErrorReadLine();
            tExitWatcher.Start();
        }
        void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if(OutputDataReceived != null)
            {
                OutputDataReceived(outLine.Data);
            }
        }
        void ErrorHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (OutputDataReceived != null)
            {
                OutputDataReceived(outLine.Data);
            }
        }
    }
}
