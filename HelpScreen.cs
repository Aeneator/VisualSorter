using System.Collections.Generic;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;


namespace VisualSorter
{
    public class HelpScreen
    {

        public void CreateHelpWindow()
        {
            MaterialForm Window = new MaterialForm();
            Window.Size = new Size(1163, 800);//1163, 657
            Window.MinimumSize = Window.Size;
            Window.MaximumSize = Window.Size;
            Window.BackColor = MyColors.Primary;
            Window.Text = "Help";
            Window.MaximizeBox = false;

            List<Panel> Pages = new List<Panel>();
            List<MaterialButton> PageButtons = new List<MaterialButton>();

            MaterialCard TopBar = new MaterialCard();
            TopBar.Size = new Size(Window.Width, 45);
            TopBar.Dock = DockStyle.Top;
            TopBar.BackColor = MyColors.Primary;
            Window.Controls.Add(TopBar);

            Panel MainPanel = new Panel();
            MainPanel.Location = new Point(0,TopBar.Height+73);
            MainPanel.Size = new Size(Window.Width, Window.Height - MainPanel.Location.Y);
            Window.Controls.Add(MainPanel);


            CreatePageSwitchButton("How to load your Images", 1, TopBar.Width/3, TopBar, Pages,PageButtons);
            CreatePageSwitchButton("Tips and tricks", 2, 2* TopBar.Width / 3, TopBar, Pages, PageButtons);

            CreatePage1(Pages, MainPanel);

            CreatePage2(Pages, MainPanel);

            SwitchToPage(1,Pages,PageButtons);

            Window.Show();
        }

        private void CreatePage1(List<Panel> Pages, Panel MainPanel)
        {
            FlowLayoutPanel MainLayout = new FlowLayoutPanel();
            Pages.Add(MainLayout);
            MainLayout.Dock = DockStyle.Fill;
            MainLayout.WrapContents = false;
            MainLayout.AutoScroll = true;
            MainLayout.FlowDirection = FlowDirection.TopDown;
            MainPanel.Controls.Add(MainLayout);

            CreateTextWithImage(MainLayout, Properties.Resources.HelpPage1Img1, "1) Upload the images that need to be sorted into the \"Source Folder\". This folder can be opened by pressing this button:");
            CreateTextWithImage(MainLayout, Properties.Resources.HelpPage1Img2, "2) After uploading your images, press the \"Load Source Folder\" button to load the images from the \"Source Folder\" into the application.");
            CreateTextWithImage(MainLayout, Properties.Resources.HelpPage1Img3, "3) After loading your images in the application, use these buttons to navigate and create new categories. ");
        }

        private void CreatePage2(List<Panel> Pages, Panel MainPanel)
        {
            FlowLayoutPanel MainLayout = new FlowLayoutPanel();
            Pages.Add(MainLayout);
            MainLayout.Dock = DockStyle.Fill;
            MainLayout.WrapContents = false;
            MainLayout.AutoScroll = true;
            MainLayout.FlowDirection = FlowDirection.TopDown;
            MainPanel.Controls.Add(MainLayout);

            CreateTextPanel(MainLayout, "1) The application will remember the current picture and the categories you created if you enable the \"Save Progress\" toggle.");
            CreateTextPanel(MainLayout, "2) Removing a \"Category Button\" will not delete its associated folder.");
            CreateTextPanel(MainLayout, "3) The \"Multiple Categories\" checkbox will stop the program from skipping to the next image after clicking on a category.");
            CreateTextPanel(MainLayout, "4) To better control the order that your images are loaded into the application, you can create folders in the \"Source Folder\" to better organize them.");
        }

        private void CreateTextWithImage(Control MainLayout, Image inputImage, string inputText)
        {

            Panel p = new Panel();
            p.Size = new Size(MainLayout.Width - 25, 600);
            MainLayout.Controls.Add(p);

            MaterialLabel Text = new MaterialLabel();
            Text.AutoSize = true;
            Text.Text = inputText;
            Text.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            Text.Location = new Point((MainLayout.Width - TextWidth(Text.Text, Text.Font)) / 2 , 20);
            p.Controls.Add(Text);

            PictureBox Picture = new PictureBox();
            Picture.Size = new Size(MainLayout.Width - 200, 500);
            Picture.Location = new Point((MainLayout.Width - Picture.Width) / 2, 60);
            Picture.BackgroundImage = inputImage;
            Picture.BackgroundImageLayout = ImageLayout.Zoom;
            p.Controls.Add(Picture);
        }

        private void CreateTextPanel(Control MainLayout,  string inputText) {
            Panel p = new Panel();
            p.Size = new Size(MainLayout.Width - 25, 50);
            MainLayout.Controls.Add(p);

            MaterialLabel Text = new MaterialLabel();
            Text.AutoSize = true;
            Text.Text = inputText;
            Text.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            Text.Location = new Point((MainLayout.Width - TextWidth(Text.Text, Text.Font)) / 2, 20);
            p.Controls.Add(Text);

        
        }


        private void CreatePageSwitchButton(string name, int id, int X, MaterialCard TopBar, List<Panel> Pages, List<MaterialButton> PageButtons)
        {
            MaterialButton PageButton = new MaterialButton();
            PageButton.AutoSize = false;
            PageButton.Width = 200;
            PageButton.Location = new Point(X-PageButton.Width/2, (TopBar.Height - PageButton.Height) / 2);
            PageButton.Text = name ;
            PageButton.DrawShadows = true;
            PageButton.Click += (s, e) => { SwitchToPage(id, Pages,PageButtons); };
            TopBar.Controls.Add(PageButton);
            
            PageButtons.Add(PageButton);
        }

        private void SwitchToPage(int num,List<Panel> Pages, List<MaterialButton> PageButtons)
        {
            foreach (Panel p in Pages)
            {
                p.Visible = false;
            }
            Pages[num-1].Visible = true;

            foreach(MaterialButton button in PageButtons)
            {
                button.HighEmphasis = false;
            }
            PageButtons[num-1].HighEmphasis = true;

        }

        public int TextWidth(string text, Font f)
        {
            float textWidth = 0;

            using (Bitmap bmp = new Bitmap(1, 1))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                textWidth = g.MeasureString(text, f).Width;
            }

            return (int)textWidth;
        }


    }
}
