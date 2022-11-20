using System.Drawing;
using Guna.UI2.WinForms;

namespace VisualSorter
{
    public static class MyColors
    {

        public static Color Primary = ColorTranslator.FromHtml("#424242");
        public static Color HoverColor = ColorTranslator.FromHtml("#6F3C3C");
        public static Color Accent = ColorTranslator.FromHtml("#D50000");

        public static void setGunaButtonColor(Guna2Button c)
        {
            c.FillColor = Primary;
            c.HoverState.FillColor = HoverColor;
            c.PressedColor = Accent;
        }
    }
}