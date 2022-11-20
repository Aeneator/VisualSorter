using System.Linq;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Guna.UI2.WinForms;

namespace VisualSorter
{


    public class FileManager
    {

        public void changeImage(int arg)
        {
            Form1.f.CategoryButtons.resetButtonBorders();

            if (Form1.ImageIndex < 0 || Form1.ImageIndex >= Form1.f.ImagePaths.Length)
                Form1.ImageIndex = 0;

            if (Form1.f.ImageView.Image != null)
                Form1.f.ImageView.Image.Dispose();
            Form1.f.ImageView.Image = null;

            if (Form1.f.ImagePaths[0] == "empty")
            {
                setEmptyImage();
                return;
            }

            if (arg == -1)
                if (Form1.ImageIndex > 0) Form1.ImageIndex -= 1;
            if (arg == +1)
                if (Form1.ImageIndex < Form1.f.ImagePaths.Length - 1) Form1.ImageIndex += 1;

            if (!File.Exists(Form1.f.ImagePaths[Form1.ImageIndex]))
            {
                foreach (string file in Form1.f.ImagePaths)
                    if (!File.Exists(file))
                        DeleteImage(file);
            }

            Form1.f.Memory.UpdateMemoryINT("CurrentImage", Form1.ImageIndex);

            if (Form1.ImageIndex == 0 && Form1.ImageIndex == Form1.f.ImagePaths.Length - 1)
            {
                Form1.f.bttn_Previous.Visible = false;
                Form1.f.bttn_Next.Visible = false;
            }
            else if (Form1.ImageIndex == 0)
            {
                Form1.f.bttn_Previous.Visible = false;
                Form1.f.bttn_Next.Visible = true;
            }
            else if (Form1.ImageIndex == Form1.f.ImagePaths.Length - 1)
            {
                Form1.f.bttn_Previous.Visible = true;
                Form1.f.bttn_Next.Visible = false;
            }
            else
            {
                Form1.f.bttn_Previous.Visible = true;
                Form1.f.bttn_Next.Visible = true;
            }

            if (Form1.ImageIndex < Form1.f.ImageNames.Length)
                Form1.f.ToolTip.SetToolTip(Form1.f.ImageView, Form1.f.ImageNames[Form1.ImageIndex]);

            if (Form1.ImageIndex < Form1.f.ImagePaths.Length && File.Exists(Form1.f.ImagePaths[Form1.ImageIndex]))
                Form1.f.ImageView.Image = Image.FromFile(Form1.f.ImagePaths[Form1.ImageIndex]);

            Form1.f.LabelCount.Text = (Form1.ImageIndex + 1).ToString() + " / " + (Form1.f.ImagePaths.Length).ToString();
        }


        public void setEmptyImage()
        {
            
            Form1.f.ImageView.Image = Properties.Resources.Empty;
            Form1.f.bttn_Previous.Visible = false;
            Form1.f.bttn_Next.Visible = false;

            Form1.f.LabelCount.Text = "0 / 0";
        }

        public void checkIfSourceFolderIsEmpty()
        {
            if (Form1.f.ImagePaths.Length <= 0)
            {
                Form1.f.ImagePaths = new string[1];
                Form1.f.ImageNames = new string[1];
                Form1.f.ImagePaths[0] = "empty";
                Form1.f.ImageNames[0] = "Empty";
            }

            changeImage(0);
        }

        public void CreateFolder(string FolderName)
        {
            string FolderToCreate = Form1.f.startupPath + "\\" + Form1.f.OutputFolderName + "\\" + FolderName;

            if (!Directory.Exists(FolderToCreate))
                Directory.CreateDirectory(FolderToCreate);
        }

        public void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }

        public void DeleteImage(string path)
        {
            if (Form1.f.ImagePaths.Length > 0)
            {
                if (File.Exists(path) && Path.GetFileName(path) != "Empty.png")
                {
                    if (Form1.f.ImageView.Image != null)
                        Form1.f.ImageView.Image.Dispose();
                    Form1.f.ImageView.Image = null;

                    File.Delete(path);
                }

                Form1.f.ImagePaths = Form1.f.ImagePaths.Except(new string[] { path }).ToArray();
                Form1.f.ImageNames = Form1.f.ImageNames.Except(new string[] { path }).ToArray();

                if (Form1.ImageIndex >= Form1.f.ImagePaths.Length)
                    Form1.ImageIndex = Form1.f.ImagePaths.Length - 1;

                if (Form1.f.ImagePaths.Length != 0)
                    Form1.f.JumpToImage.Maximum = Form1.f.ImagePaths.Length;

                checkIfSourceFolderIsEmpty();
            }
        }

        public void CopyFiles(string sourcePath, string destinationPath)
        {
            if (Directory.Exists(destinationPath) && !File.Exists(destinationPath + Form1.f.ImageNames[Form1.ImageIndex]) && Form1.f.ImageNames[0] != "Empty")
            {
                File.Copy(sourcePath, destinationPath + Form1.f.ImageNames[Form1.ImageIndex]);
            }
        }

    }
}
