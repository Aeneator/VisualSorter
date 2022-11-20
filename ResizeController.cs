using System.Drawing;
using System.Windows.Forms;

namespace VisualSorter
{
    public class ResizeController
    {
        private Form1 F;

        private Rectangle OriginalFormSize;
        private Rectangle OriginalImageViewSize;
        private Rectangle OriginalCategoryButtonsPanelSize;

        public void Load()
        {
            F = Form1.f;

            OriginalFormSize = new Rectangle(F.Location.X, F.Location.Y, F.Size.Width, F.Size.Height);
            OriginalImageViewSize = new Rectangle(F.ImageView.Location.X, F.ImageView.Location.Y, F.ImageView.Size.Width, F.ImageView.Size.Height);
            OriginalCategoryButtonsPanelSize = new Rectangle(F.CategoryButtonsPanel.Location.X, F.CategoryButtonsPanel.Location.Y, F.CategoryButtonsPanel.Size.Width, F.CategoryButtonsPanel.Size.Height);

            OnResize();
        }

        public void OnResize()
        {
            ResizeImageView(OriginalImageViewSize, F.ImageView);
            ResizeCategoryPanel(OriginalCategoryButtonsPanelSize, F.CategoryButtonsPanel);
        }

        private void ResizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(F.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(F.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void ResizeImageView(Rectangle r, Control c)
        {
            int padding = 10;

            float xRatio = (float)(F.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(F.Height) / (float)(OriginalFormSize.Height);

            int TopHeight = 120;

            int newX = (int)(r.Location.X * xRatio) + padding;
            int newY = TopHeight;

            int newWidth = F.Width - F.RightPanel.Width - padding * 4;
            int newHeight = F.Height - TopHeight - padding;

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void ResizeCategoryPanel(Rectangle r, Control c)
        {
            int padding = 10;

            float xRatio = (float)(F.Width) / (float)(OriginalFormSize.Width);

            int newX = (int)(r.Location.X * xRatio) + padding;

            int newHeight = F.RightPanel.Height - F.TopRightPanel.Height  - padding;

            c.Location = new Point(newX, c.Location.Y);
            c.Size = new Size(c.Width, newHeight);
        }


    }
}
