using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace VisualSorter
{
    public class ContactScreen
    {

        public void OpenContactScreen()
        {
            MaterialForm Window = new MaterialForm();
            Window.Size = new Size(450, 480);//1163, 657
            Window.MinimumSize = Window.Size;
            Window.MaximumSize = Window.Size;
            Window.BackColor = MyColors.Primary;
            Window.Text = "Developer Contact:";
            Window.MaximizeBox = false;


            Panel MainPanel = new Panel();
            MainPanel.Location = new Point(0, 73);
            MainPanel.Size = new Size(Window.Width, Window.Height - MainPanel.Location.Y);
            Window.Controls.Add(MainPanel);

            MaterialLabel Text1 = new MaterialLabel();
            Text1.AutoSize = true;
            Text1.Text = "This application was developed by Pilescu Adrian Mihai.";
            Text1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            Text1.Location = new Point((MainPanel.Width - Form1.f.HelpScreen.TextWidth(Text1.Text, Text1.Font)) / 2 + 8, 30);
            MainPanel.Controls.Add(Text1);

            PictureBox Picture = new PictureBox();
            Picture.Size = new Size(MainPanel.Width - 200, 250);
            Picture.Location = new Point((MainPanel.Width - Picture.Width) / 2, 70);
            Picture.BackgroundImage = Properties.Resources.Profile;
            Picture.BackgroundImageLayout = ImageLayout.Zoom;
            MainPanel.Controls.Add(Picture);

            MaterialLabel Text2 = new MaterialLabel();
            Text2.AutoSize = true;
            Text2.Text = "For any information, you can contact me at";
            Text2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            Text2.Location = new Point((MainPanel.Width - Form1.f.HelpScreen.TextWidth(Text2.Text, Text2.Font)) / 2 + 8, 340);
            MainPanel.Controls.Add(Text2);


            MaterialLabel Text3 = new MaterialLabel();
            Text3.AutoSize = true;
            Text3.Text = "adi.pilescu@gmail.com";
            Text3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            Text3.Location = new Point((MainPanel.Width - Form1.f.HelpScreen.TextWidth(Text3.Text, Text3.Font)) / 2 + 8, 360);
            Text3.UseAccent = true;
            Text3.HighEmphasis = true;
            MainPanel.Controls.Add(Text3);
            
            
            Window.Show();
        }
    }
}
