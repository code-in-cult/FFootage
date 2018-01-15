using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFTool.tools
{
    class EmbeddedResourceExtractor
    {
        public static void Extract(string filename, string workFolderName)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FFTool.ebin." + filename);
            string pathdir = Path.Combine(Application.StartupPath, workFolderName);
            string fullpath = Path.Combine(pathdir, filename);

            if (!Directory.Exists(pathdir))
            {
                Directory.CreateDirectory(pathdir);
            }

            if (!File.Exists(fullpath))
            {
                FileStream fileStream = new FileStream(fullpath, FileMode.CreateNew);
                for (int i = 0; i < stream.Length; i++)
                {
                    fileStream.WriteByte((byte)stream.ReadByte());
                }
                fileStream.Close();
            }
        }
    }
}
