using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using Guna.UI2.WinForms;
using MaterialSkin.Controls;


namespace VisualSorter
{

    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public static Form1 f = null;
        public MemoryManager Memory = new MemoryManager();
        public Categories CategoryButtons = new Categories();
        private ResizeController ResizeCnt = new ResizeController();
        public FileManager FileM = new FileManager();
        public HelpScreen HelpScreen = new HelpScreen();
        public ContactScreen ContactScreen = new ContactScreen();


        public string startupPath;
        public string[] ImagePaths;
        public string[] ImageNames;
        public static int ImageIndex = 0;

        public string OutputFolderName = "Sorted Images";

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Red700, MaterialSkin.Accent.Red700,MaterialSkin.TextShade.WHITE);

            f = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startupPath = Environment.CurrentDirectory;
            Memory.MemoryFolderPath = startupPath + "\\Memory\\";

            if (!Directory.Exists(startupPath + "\\Images"))
                Directory.CreateDirectory(startupPath + "\\Images");

            if (!Directory.Exists(startupPath + "\\Sorted Images"))
                Directory.CreateDirectory(startupPath + "\\Sorted Images");

            LoadImagesInApp();

            Memory.CreateMemoryFiles();
            
            Memory.RestorePreviosState();

            FileM.checkIfSourceFolderIsEmpty();

            ResizeCnt.Load();

            FileM.changeImage(0);

            SetColors();

        }

        public void LoadImagesInApp()
        {
            ImagePaths = Directory.EnumerateFiles(startupPath + @"\Images", "*.*", SearchOption.AllDirectories).Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("jpeg") || file.ToLower().EndsWith("png") || file.ToLower().EndsWith("bmp") || file.ToLower().EndsWith("gif")).ToArray();
            ImageNames = new string[ImagePaths.Length];
            for (int i = 0; i < ImagePaths.Length; i++) ImageNames[i] = Path.GetFileName(ImagePaths[i]);

            if (ImageIndex > ImagePaths.Length)
                ImageIndex = 0;

            if (ImagePaths.Length != 0)
                JumpToImage.Maximum = ImagePaths.Length;
            else JumpToImage.Maximum = 1;
        }

        private void SetColors()
        {
            JumpToImage.FillColor = MyColors.Primary;
            JumpToImage.ForeColor = Color.White;

            NumInputUp.ForeColor = MyColors.Primary;
            NumInputDown.ForeColor = MyColors.Primary;

            setGunaButtonToMaterial(bttn_Next);
            setGunaButtonToMaterial(bttn_Previous);
            setGunaButtonToMaterial(RotateButton);
        }

        public void setGunaButtonToMaterial(Guna2Button button)
        {
            button.Animated = true;
            button.IndicateFocus = false;
            button.BorderRadius = 4;

            button.ShadowDecoration.Enabled = true;
            button.ShadowDecoration.Color = Color.Black;
            button.ShadowDecoration.BorderRadius = button.BorderRadius;
            button.ShadowDecoration.Depth = 5;

            if (button.Image != null)
            {
                button.ImageSize = ResizeToContainer(button);
                //button.ImageOffset = new Point(1, 0);
            }
            MyColors.setGunaButtonColor(button);
        }

        private Size ResizeToContainer(Guna2Button box)
        {
            double ratio = Math.Max((double)box.Image.Width / (double)box.Width, (double)box.Image.Height / (double)box.Height);
            int width = (int)(box.Image.Width / ratio);
            int height = (int)(box.Image.Height / ratio);

            return new Size(width,height);
        }

        private void CreateCategoryGroup_Click(object sender, EventArgs ev)
        {
            if (InputField.Text != "")
            {
                CategoryButtons.CreateButtonGroup(InputField.Text, CategoryButtonsPanel);
                FileM.CreateFolder(InputField.Text);
                InputField.Text = "";
            }
        }

        private void SaveStateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Memory.UpdateMemoryINT("SaveState", SaveStateCheckBox.Checked);
        }

        private void ReloadImages_Click(object sender, EventArgs e)
        {
            LoadImagesInApp();
            FileM.checkIfSourceFolderIsEmpty();

            FileM.changeImage(0);
        }

        private void Form1_Closing(Object sender, FormClosingEventArgs e)
        {
            Memory.SaveStateOnClose();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeCnt.OnResize();
        }
        private void bttn_Next_Click(object sender, EventArgs e)
        {
            FileM.changeImage(+1);
        }
        private void bttn_Previous_Click(object sender, EventArgs e)
        {
            FileM.changeImage(-1);
        }
        private void SortedImages_Click(object sender, EventArgs e)
        {
            FileM.OpenFolder(startupPath + "\\Sorted Images");
        }
        private void SourceFolder_Click(object sender, EventArgs e)
        {
            FileM.OpenFolder(startupPath + "\\Images");
        }
        private void TrashButton_Click(object sender, EventArgs e)
        {
            FileM.DeleteImage(ImagePaths[ImageIndex]);
        }
        private void RotateButton_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)ImageView.Image;
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            ImageView.Image = bitmap;
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpScreen.CreateHelpWindow();
        }
        private void ContactButton_Click(object sender, EventArgs e)
        {
            ContactScreen.OpenContactScreen();
        }

        private void NumInputUp_Click(object sender, EventArgs e)
        {
            if (JumpToImage.Value != JumpToImage.Maximum)
            JumpToImage.Value++;
        }

        private void NumInputDown_Click(object sender, EventArgs e)
        {
            if (JumpToImage.Value != JumpToImage.Minimum)
            JumpToImage.Value--;
        }

        private void JumpToImageEnter_Click(object sender, EventArgs e)
        {
            ImageIndex = (int)JumpToImage.Value -1;
            FileM.changeImage(0);
            
        }

        private void RemoveFromFolders_Click(object sender, EventArgs e)
        {
            CategoryButtons.resetButtonBorders();
            string[] AllSortedImages = Directory.EnumerateFiles(startupPath + @"\Sorted Images", "*.*", SearchOption.AllDirectories).Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("jpeg") || file.ToLower().EndsWith("png") || file.ToLower().EndsWith("bmp") || file.ToLower().EndsWith("gif")).ToArray();
            
            for (int i = 0; i < AllSortedImages.Length; i++)
            {
                if (AllSortedImages[i].Contains(ImageNames[ImageIndex]))
                {
                    if (File.Exists(AllSortedImages[i]))
                        File.Delete(AllSortedImages[i]);
                }
            }   
        }





        // Really usefull:
        // Add delete file (DONE)
        // Generate the memory files on Load if they don't exist (DONE)
        // Make a control scaling class (DONE)
        // Work on the design (DONE)
        // Find name and Icon for the project (DONE)
        // Add Json memory for current image and Categories (100% done)
        // Add button to remove category (DONE)
        // Dynamic scaling of the window (DONE)
        // Multiple Categories check (DONE)
        // Fix the wrong file type load bug (DONE)
        // Find a way to create an executable (DONE)

        // Allow keyboard inputs
        // Make reload button bigger

        // Good to have:
        // Undo button (NEVER)

    }
}
