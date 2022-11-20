using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MaterialSkin.Controls;


namespace VisualSorter
{
    public class Categories
    {

        public List<Panel> CategoryGroups = new List<Panel>();

        int PaddingHorizontal = 5;

        int GroupIndex = 0;

        public void CreateButtonGroup(string name, Control flowPanel)
        {
            Panel group = new Panel();
            group.Name = GroupIndex++.ToString();

            group.Width = 320; 

            if (name.Length <= 34)
                group.Height = 71;
            else
                group.Height = 100;

            Form1.f.CategoryButtonsPanel.Controls.Add(group);

            int ButtonSize = (int)(group.Width * 0.10);
            Console.WriteLine((int)(group.Width - ButtonSize - PaddingHorizontal - 21));

            CreateCategoryButton(name, ButtonSize, group);

            CreateCategoryMoveButton(0, Properties.Resources.UpArrowSlim,-1,group, ButtonSize);
            CreateCategoryMoveButton(group.Height / 2, Properties.Resources.DownArrowSlim, +1, group, ButtonSize);

            CreateRemoveButton(name, ButtonSize, group, group.Name);

            CategoryGroups.Add(group);
        }

        private void CreateCategoryButton (string name, int ButtonSize, Panel group)
        {
            Guna2Button categoryButton = new Guna2Button();

            categoryButton.Location = new Point(0, 0);
            categoryButton.Size = new Size((int)(group.Width - ButtonSize - PaddingHorizontal -21), group.Height);
            categoryButton.Name = "textBox";
            categoryButton.AutoSize = false;
            categoryButton.Text = name;
            categoryButton.Font = new Font("Segoe UI", 18);
            categoryButton.ForeColor = Color.White;
            categoryButton.Click += (s, e) => { CategoryButtonFunction(name, categoryButton); };

            categoryButton.BorderColor = MyColors.Accent;

            Form1.f.setGunaButtonToMaterial(categoryButton);

            Form1.f.ToolTip.SetToolTip(categoryButton, "Add current image to category");

            group.Controls.Add(categoryButton);
        }

        private void CategoryButtonFunction(string name, Guna2Button myButton)
        {
            myButton.BorderThickness = 2;

            if (Directory.Exists(Form1.f.startupPath + "\\" + Form1.f.OutputFolderName + "\\" + name))
                Form1.f.FileM.CopyFiles(Form1.f.ImagePaths[Form1.ImageIndex], Form1.f.startupPath + "\\" + Form1.f.OutputFolderName + "\\" + name + "\\");
            else
            {
                Form1.f.FileM.CreateFolder(name);
                Form1.f.FileM.CopyFiles(Form1.f.ImagePaths[Form1.ImageIndex], Form1.f.startupPath + "\\" + Form1.f.OutputFolderName + "\\" + name + "\\");
            }

            if (!Form1.f.CategoriesCheckBox.Checked)
                Form1.f.FileM.changeImage(+1);
        }

        private void CreateRemoveButton(string name, int ButtonWidth,Panel Group, string ParentIndex)
        {
            Guna2Button removeButton = new Guna2Button();

            removeButton.Location = new Point(Group.Width - ButtonWidth, (Group.Height - ButtonWidth) /2);
            removeButton.Height = ButtonWidth;
            removeButton.Width = ButtonWidth;
            removeButton.Image = Properties.Resources.XSign;
            removeButton.Click += (s, e) => { RemoveCategoryButtonFunction(ParentIndex); };

            Form1.f.setGunaButtonToMaterial(removeButton);
            Form1.f.ToolTip.SetToolTip(removeButton, "Remove category");

            Group.Controls.Add(removeButton);
        }

        private void RemoveCategoryButtonFunction(string name)
        {
            foreach (Panel item in CategoryGroups)
            {
                if (item.Name == name)
                {
                    CategoryGroups.Remove(item);
                    item.Dispose();
                    break;
                }
            }
        }

        private void CreateCategoryMoveButton(int y, Image img, int value, Panel group, int ButtonSize) {
            Guna2Button ButtonMove = new Guna2Button();
            ButtonMove.Size = new Size(20, group.Height / 2);
            ButtonMove.Location = new Point((int)(group.Width - ButtonSize - PaddingHorizontal - 19), y);
            ButtonMove.Image = img;
            ButtonMove.Click += (s, e) => { MoveCategoryButtonFunction(value, group); };
            group.Controls.Add(ButtonMove);
            Form1.f.setGunaButtonToMaterial(ButtonMove);
        }

        public void MoveCategoryButtonFunction(int value, Panel group)
        {

            int myIndex = Form1.f.CategoryButtonsPanel.Controls.GetChildIndex(group) + value;

            if (myIndex >= 0 && myIndex < Form1.f.CategoryButtonsPanel.Controls.Count)
            {
                Form1.f.CategoryButtonsPanel.Controls.SetChildIndex(group, myIndex);
                CategoryGroups.Swap(myIndex - value, myIndex);
            }
        }

        public void resetButtonBorders()
        {
            foreach (Panel item in CategoryGroups)
            {
                foreach (dynamic child in item.Controls)
                {
                    if (child is Guna2Button)
                    {
                        child.BorderThickness = 0;
                        break;
                    }
                }
            }
        }


    }

    public static class Extensions
    {
        public static void Swap<T>(this List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }

}

