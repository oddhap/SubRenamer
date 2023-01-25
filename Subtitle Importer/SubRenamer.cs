using Microsoft.VisualBasic;
using System.IO;

namespace Subtitle_Importer
{
    public partial class frm_SubtitleImporter : Form
    {
        public frm_SubtitleImporter()
        {
            InitializeComponent();
        }

        private void btnSelFolder_Click(object sender, EventArgs e)
        {
            string path = "";
            string destination = "";
            string searchString = tbLanguage.Text;
            string prefix = tbPrefix.Text;
            string extension = "." + tbExt.Text;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                path = folderBrowserDialog1.SelectedPath; // specify the path of the folder here
                destination = folderBrowserDialog1.SelectedPath;
            }

            ProcessDirectory(path, searchString, destination, prefix, extension);
            MessageBox.Show("Done");
            
        }

        public static void ProcessDirectory(string targetDirectory, string searchString, string destination, string prefix, string extension)
        {
            string[] subdirectories = Directory.GetDirectories(targetDirectory);

            foreach (string subdirectory in subdirectories)
            {
                ProcessDirectory(subdirectory, searchString, destination, prefix, extension);
                string[] files = Directory.GetFiles(subdirectory);
                string subfolderName = Path.GetFileName(subdirectory);

                long largestFileSize = 0;
                string largestFile = "";

                foreach (string file in files)
                {
                    if (file.EndsWith(extension) && file.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    { // specify the file extension to be renamed here
                        FileInfo fileInfo = new FileInfo(file);
                        long fileSize = fileInfo.Length;
                        if (fileSize > largestFileSize)
                        {
                            largestFileSize = fileSize;
                            largestFile = file;
                        }
                    }
                }
                if (largestFile != "")
                {
                    string newFileName = Path.Combine(subdirectory, subfolderName + "." + prefix + Path.GetExtension(largestFile));
                    File.Copy(largestFile, Path.Combine(destination, Path.GetFileName(newFileName)));
                    Console.WriteLine("Renamed " + largestFile + " to " + newFileName + " and copied to " + destination);
                }
                else
                {
                    Console.WriteLine("No files found containing the specified string in the filename in " + subdirectory);
                }
            }
        }
    }
}