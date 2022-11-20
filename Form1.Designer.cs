
namespace VisualSorter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RightPanel = new System.Windows.Forms.Panel();
            this.CategoryButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TopRightPanel = new System.Windows.Forms.Panel();
            this.CreateCategoryGroup = new MaterialSkin.Controls.MaterialButton();
            this.CategoriesCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.bttn_Next = new Guna.UI2.WinForms.Guna2Button();
            this.InputField = new MaterialSkin.Controls.MaterialTextBox();
            this.RotateButton = new Guna.UI2.WinForms.Guna2Button();
            this.bttn_Previous = new Guna.UI2.WinForms.Guna2Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SaveStateCheckBox = new MaterialSkin.Controls.MaterialSwitch();
            this.JumpToImage = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.JumpToImageEnter = new MaterialSkin.Controls.MaterialButton();
            this.RemoveFromFolders = new MaterialSkin.Controls.MaterialButton();
            this.NumInputDown = new System.Windows.Forms.Button();
            this.NumInputUp = new System.Windows.Forms.Button();
            this.TrashButton = new MaterialSkin.Controls.MaterialButton();
            this.HelpButton = new MaterialSkin.Controls.MaterialButton();
            this.SortedImages = new MaterialSkin.Controls.MaterialButton();
            this.SourceFolder = new MaterialSkin.Controls.MaterialButton();
            this.ReloadImages = new MaterialSkin.Controls.MaterialButton();
            this.ImageView = new System.Windows.Forms.PictureBox();
            this.LabelCount = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.ContactButton = new MaterialSkin.Controls.MaterialButton();
            this.RightPanel.SuspendLayout();
            this.TopRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumpToImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BackColor = System.Drawing.Color.Transparent;
            this.RightPanel.Controls.Add(this.CategoryButtonsPanel);
            this.RightPanel.Controls.Add(this.TopRightPanel);
            this.RightPanel.Location = new System.Drawing.Point(784, 109);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(376, 542);
            this.RightPanel.TabIndex = 12;
            // 
            // CategoryButtonsPanel
            // 
            this.CategoryButtonsPanel.AutoScroll = true;
            this.CategoryButtonsPanel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryButtonsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CategoryButtonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CategoryButtonsPanel.Location = new System.Drawing.Point(3, 214);
            this.CategoryButtonsPanel.Name = "CategoryButtonsPanel";
            this.CategoryButtonsPanel.Size = new System.Drawing.Size(352, 325);
            this.CategoryButtonsPanel.TabIndex = 10;
            this.CategoryButtonsPanel.WrapContents = false;
            // 
            // TopRightPanel
            // 
            this.TopRightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopRightPanel.Controls.Add(this.CreateCategoryGroup);
            this.TopRightPanel.Controls.Add(this.CategoriesCheckBox);
            this.TopRightPanel.Controls.Add(this.bttn_Next);
            this.TopRightPanel.Controls.Add(this.InputField);
            this.TopRightPanel.Controls.Add(this.RotateButton);
            this.TopRightPanel.Controls.Add(this.bttn_Previous);
            this.TopRightPanel.Location = new System.Drawing.Point(3, 0);
            this.TopRightPanel.Name = "TopRightPanel";
            this.TopRightPanel.Size = new System.Drawing.Size(352, 211);
            this.TopRightPanel.TabIndex = 14;
            // 
            // CreateCategoryGroup
            // 
            this.CreateCategoryGroup.AutoSize = false;
            this.CreateCategoryGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateCategoryGroup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateCategoryGroup.Depth = 0;
            this.CreateCategoryGroup.HighEmphasis = true;
            this.CreateCategoryGroup.Icon = global::VisualSorter.Properties.Resources.PlusSign;
            this.CreateCategoryGroup.Image = global::VisualSorter.Properties.Resources.CheckSymbol;
            this.CreateCategoryGroup.Location = new System.Drawing.Point(259, 146);
            this.CreateCategoryGroup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateCategoryGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateCategoryGroup.Name = "CreateCategoryGroup";
            this.CreateCategoryGroup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateCategoryGroup.Size = new System.Drawing.Size(78, 50);
            this.CreateCategoryGroup.TabIndex = 35;
            this.CreateCategoryGroup.Text = "Add";
            this.ToolTip.SetToolTip(this.CreateCategoryGroup, "Create a new category");
            this.CreateCategoryGroup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateCategoryGroup.UseAccentColor = false;
            this.CreateCategoryGroup.UseVisualStyleBackColor = true;
            this.CreateCategoryGroup.Click += new System.EventHandler(this.CreateCategoryGroup_Click);
            // 
            // CategoriesCheckBox
            // 
            this.CategoriesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoriesCheckBox.AutoSize = true;
            this.CategoriesCheckBox.BackColor = System.Drawing.Color.LightGray;
            this.CategoriesCheckBox.Depth = 0;
            this.CategoriesCheckBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.CategoriesCheckBox.Location = new System.Drawing.Point(16, 97);
            this.CategoriesCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.CategoriesCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CategoriesCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CategoriesCheckBox.Name = "CategoriesCheckBox";
            this.CategoriesCheckBox.ReadOnly = false;
            this.CategoriesCheckBox.Ripple = true;
            this.CategoriesCheckBox.Size = new System.Drawing.Size(169, 37);
            this.CategoriesCheckBox.TabIndex = 35;
            this.CategoriesCheckBox.Text = "Multiple categories";
            this.ToolTip.SetToolTip(this.CategoriesCheckBox, "Select multiple categories for the current image");
            this.CategoriesCheckBox.UseVisualStyleBackColor = false;
            // 
            // bttn_Next
            // 
            this.bttn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Next.Animated = true;
            this.bttn_Next.BackColor = System.Drawing.Color.Maroon;
            this.bttn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_Next.BorderColor = System.Drawing.Color.Transparent;
            this.bttn_Next.BorderRadius = 10;
            this.bttn_Next.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.bttn_Next.CustomBorderColor = System.Drawing.Color.Black;
            this.bttn_Next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttn_Next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttn_Next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttn_Next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttn_Next.FillColor = System.Drawing.Color.Transparent;
            this.bttn_Next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_Next.ForeColor = System.Drawing.Color.Transparent;
            this.bttn_Next.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.bttn_Next.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.bttn_Next.Image = global::VisualSorter.Properties.Resources.ArrowRight;
            this.bttn_Next.ImageSize = new System.Drawing.Size(82, 62);
            this.bttn_Next.IndicateFocus = true;
            this.bttn_Next.Location = new System.Drawing.Point(111, 17);
            this.bttn_Next.Name = "bttn_Next";
            this.bttn_Next.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.bttn_Next.ShadowDecoration.Depth = 100;
            this.bttn_Next.Size = new System.Drawing.Size(89, 62);
            this.bttn_Next.TabIndex = 20;
            this.ToolTip.SetToolTip(this.bttn_Next, "Next Image");
            this.bttn_Next.Click += new System.EventHandler(this.bttn_Next_Click);
            // 
            // InputField
            // 
            this.InputField.AnimateReadOnly = false;
            this.InputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputField.Depth = 0;
            this.InputField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InputField.Hint = "Category name:";
            this.InputField.LeadingIcon = null;
            this.InputField.Location = new System.Drawing.Point(16, 146);
            this.InputField.MaxLength = 51;
            this.InputField.MouseState = MaterialSkin.MouseState.OUT;
            this.InputField.Multiline = false;
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(236, 50);
            this.InputField.TabIndex = 35;
            this.InputField.Text = "";
            this.ToolTip.SetToolTip(this.InputField, "Write the category name here");
            this.InputField.TrailingIcon = null;
            // 
            // RotateButton
            // 
            this.RotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RotateButton.BackColor = System.Drawing.Color.Maroon;
            this.RotateButton.BorderColor = System.Drawing.Color.Transparent;
            this.RotateButton.CustomBorderColor = System.Drawing.Color.Black;
            this.RotateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RotateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RotateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RotateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RotateButton.FillColor = System.Drawing.Color.Transparent;
            this.RotateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RotateButton.ForeColor = System.Drawing.Color.White;
            this.RotateButton.Image = global::VisualSorter.Properties.Resources.Rotate1;
            this.RotateButton.ImageSize = new System.Drawing.Size(66, 66);
            this.RotateButton.Location = new System.Drawing.Point(248, 16);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(89, 62);
            this.RotateButton.TabIndex = 25;
            this.ToolTip.SetToolTip(this.RotateButton, "Rotate the current image");
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // bttn_Previous
            // 
            this.bttn_Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Previous.Animated = true;
            this.bttn_Previous.AutoRoundedCorners = true;
            this.bttn_Previous.BackColor = System.Drawing.Color.DarkRed;
            this.bttn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_Previous.BorderColor = System.Drawing.Color.Transparent;
            this.bttn_Previous.BorderRadius = 30;
            this.bttn_Previous.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.bttn_Previous.CustomBorderColor = System.Drawing.Color.Black;
            this.bttn_Previous.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttn_Previous.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttn_Previous.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttn_Previous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttn_Previous.FillColor = System.Drawing.Color.Transparent;
            this.bttn_Previous.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_Previous.ForeColor = System.Drawing.Color.Transparent;
            this.bttn_Previous.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.bttn_Previous.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.bttn_Previous.Image = global::VisualSorter.Properties.Resources.ArrowLeft;
            this.bttn_Previous.ImageSize = new System.Drawing.Size(82, 62);
            this.bttn_Previous.IndicateFocus = true;
            this.bttn_Previous.Location = new System.Drawing.Point(16, 16);
            this.bttn_Previous.Name = "bttn_Previous";
            this.bttn_Previous.ShadowDecoration.BorderRadius = 1;
            this.bttn_Previous.ShadowDecoration.Depth = 10;
            this.bttn_Previous.Size = new System.Drawing.Size(89, 62);
            this.bttn_Previous.TabIndex = 23;
            this.ToolTip.SetToolTip(this.bttn_Previous, "Previous Image");
            this.bttn_Previous.Click += new System.EventHandler(this.bttn_Previous_Click);
            // 
            // SaveStateCheckBox
            // 
            this.SaveStateCheckBox.AutoSize = true;
            this.SaveStateCheckBox.Depth = 0;
            this.SaveStateCheckBox.Location = new System.Drawing.Point(554, 4);
            this.SaveStateCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.SaveStateCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SaveStateCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveStateCheckBox.Name = "SaveStateCheckBox";
            this.SaveStateCheckBox.Ripple = true;
            this.SaveStateCheckBox.Size = new System.Drawing.Size(159, 37);
            this.SaveStateCheckBox.TabIndex = 35;
            this.SaveStateCheckBox.Text = "Save Progress";
            this.ToolTip.SetToolTip(this.SaveStateCheckBox, "Remember the current image and created categories after closing the application");
            this.SaveStateCheckBox.UseVisualStyleBackColor = true;
            this.SaveStateCheckBox.CheckedChanged += new System.EventHandler(this.SaveStateCheckBox_CheckedChanged);
            // 
            // JumpToImage
            // 
            this.JumpToImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.JumpToImage.BackColor = System.Drawing.Color.Transparent;
            this.JumpToImage.BorderColor = System.Drawing.Color.Transparent;
            this.JumpToImage.BorderRadius = 4;
            this.JumpToImage.BorderThickness = 0;
            this.JumpToImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JumpToImage.FillColor = System.Drawing.Color.Gray;
            this.JumpToImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.JumpToImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JumpToImage.Location = new System.Drawing.Point(597, 612);
            this.JumpToImage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.JumpToImage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.JumpToImage.Name = "JumpToImage";
            this.JumpToImage.ShadowDecoration.Enabled = true;
            this.JumpToImage.Size = new System.Drawing.Size(109, 36);
            this.JumpToImage.TabIndex = 0;
            this.JumpToImage.ThousandsSeparator = true;
            this.ToolTip.SetToolTip(this.JumpToImage, "Input the image numer you want to skip to");
            this.JumpToImage.UpDownButtonBorderVisible = false;
            this.JumpToImage.UpDownButtonFillColor = System.Drawing.Color.Magenta;
            this.JumpToImage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JumpToImageEnter
            // 
            this.JumpToImageEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.JumpToImageEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.JumpToImageEnter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.JumpToImageEnter.Depth = 0;
            this.JumpToImageEnter.HighEmphasis = true;
            this.JumpToImageEnter.Icon = null;
            this.JumpToImageEnter.Location = new System.Drawing.Point(713, 612);
            this.JumpToImageEnter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.JumpToImageEnter.MouseState = MaterialSkin.MouseState.HOVER;
            this.JumpToImageEnter.Name = "JumpToImageEnter";
            this.JumpToImageEnter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.JumpToImageEnter.Size = new System.Drawing.Size(64, 36);
            this.JumpToImageEnter.TabIndex = 41;
            this.JumpToImageEnter.Text = "Go";
            this.ToolTip.SetToolTip(this.JumpToImageEnter, "Go to the selected image");
            this.JumpToImageEnter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.JumpToImageEnter.UseAccentColor = false;
            this.JumpToImageEnter.UseVisualStyleBackColor = true;
            this.JumpToImageEnter.Click += new System.EventHandler(this.JumpToImageEnter_Click);
            // 
            // RemoveFromFolders
            // 
            this.RemoveFromFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFromFolders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveFromFolders.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RemoveFromFolders.Depth = 0;
            this.RemoveFromFolders.HighEmphasis = true;
            this.RemoveFromFolders.Icon = global::VisualSorter.Properties.Resources.rollback_Icon;
            this.RemoveFromFolders.Location = new System.Drawing.Point(669, 126);
            this.RemoveFromFolders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveFromFolders.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveFromFolders.Name = "RemoveFromFolders";
            this.RemoveFromFolders.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RemoveFromFolders.Size = new System.Drawing.Size(108, 36);
            this.RemoveFromFolders.TabIndex = 44;
            this.RemoveFromFolders.Text = "Remove";
            this.ToolTip.SetToolTip(this.RemoveFromFolders, "Remove the current image from all the sorted folders");
            this.RemoveFromFolders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RemoveFromFolders.UseAccentColor = false;
            this.RemoveFromFolders.UseVisualStyleBackColor = true;
            this.RemoveFromFolders.Click += new System.EventHandler(this.RemoveFromFolders_Click);
            // 
            // NumInputDown
            // 
            this.NumInputDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumInputDown.BackgroundImage = global::VisualSorter.Properties.Resources.DownArrow;
            this.NumInputDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NumInputDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumInputDown.Location = new System.Drawing.Point(665, 630);
            this.NumInputDown.Name = "NumInputDown";
            this.NumInputDown.Size = new System.Drawing.Size(41, 18);
            this.NumInputDown.TabIndex = 43;
            this.NumInputDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolTip.SetToolTip(this.NumInputDown, "Input the image numer you want to skip to");
            this.NumInputDown.UseVisualStyleBackColor = true;
            this.NumInputDown.Click += new System.EventHandler(this.NumInputDown_Click);
            // 
            // NumInputUp
            // 
            this.NumInputUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumInputUp.BackgroundImage = global::VisualSorter.Properties.Resources.UpArrow;
            this.NumInputUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NumInputUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumInputUp.ForeColor = System.Drawing.Color.Maroon;
            this.NumInputUp.Location = new System.Drawing.Point(665, 612);
            this.NumInputUp.Margin = new System.Windows.Forms.Padding(0);
            this.NumInputUp.Name = "NumInputUp";
            this.NumInputUp.Size = new System.Drawing.Size(41, 18);
            this.NumInputUp.TabIndex = 42;
            this.NumInputUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolTip.SetToolTip(this.NumInputUp, "Input the image numer you want to skip to");
            this.NumInputUp.UseVisualStyleBackColor = true;
            this.NumInputUp.Click += new System.EventHandler(this.NumInputUp_Click);
            // 
            // TrashButton
            // 
            this.TrashButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TrashButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.TrashButton.Depth = 0;
            this.TrashButton.HighEmphasis = true;
            this.TrashButton.Icon = global::VisualSorter.Properties.Resources.Trash;
            this.TrashButton.Location = new System.Drawing.Point(8, 126);
            this.TrashButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TrashButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.TrashButton.Name = "TrashButton";
            this.TrashButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.TrashButton.Size = new System.Drawing.Size(101, 36);
            this.TrashButton.TabIndex = 35;
            this.TrashButton.Text = "Delete";
            this.ToolTip.SetToolTip(this.TrashButton, "Permanently delete the current image");
            this.TrashButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TrashButton.UseAccentColor = false;
            this.TrashButton.UseVisualStyleBackColor = true;
            this.TrashButton.Click += new System.EventHandler(this.TrashButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HelpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.HelpButton.Depth = 0;
            this.HelpButton.HighEmphasis = true;
            this.HelpButton.Icon = global::VisualSorter.Properties.Resources.InfoIcon;
            this.HelpButton.Location = new System.Drawing.Point(1035, 4);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.HelpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.HelpButton.Size = new System.Drawing.Size(86, 36);
            this.HelpButton.TabIndex = 36;
            this.HelpButton.Text = "Help";
            this.ToolTip.SetToolTip(this.HelpButton, "Open the help window");
            this.HelpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.HelpButton.UseAccentColor = false;
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SortedImages
            // 
            this.SortedImages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SortedImages.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SortedImages.Depth = 0;
            this.SortedImages.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortedImages.HighEmphasis = true;
            this.SortedImages.Icon = global::VisualSorter.Properties.Resources.Folder;
            this.SortedImages.Location = new System.Drawing.Point(388, 4);
            this.SortedImages.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SortedImages.MouseState = MaterialSkin.MouseState.HOVER;
            this.SortedImages.Name = "SortedImages";
            this.SortedImages.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SortedImages.Size = new System.Drawing.Size(162, 36);
            this.SortedImages.TabIndex = 29;
            this.SortedImages.Text = "Sorted Folder";
            this.ToolTip.SetToolTip(this.SortedImages, "Open the folder with the sorted images");
            this.SortedImages.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SortedImages.UseAccentColor = false;
            this.SortedImages.UseVisualStyleBackColor = true;
            this.SortedImages.Click += new System.EventHandler(this.SortedImages_Click);
            // 
            // SourceFolder
            // 
            this.SourceFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SourceFolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SourceFolder.Depth = 0;
            this.SourceFolder.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceFolder.HighEmphasis = true;
            this.SourceFolder.Icon = global::VisualSorter.Properties.Resources.Folder;
            this.SourceFolder.Location = new System.Drawing.Point(217, 4);
            this.SourceFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SourceFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.SourceFolder.Name = "SourceFolder";
            this.SourceFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SourceFolder.Size = new System.Drawing.Size(163, 36);
            this.SourceFolder.TabIndex = 28;
            this.SourceFolder.Text = "Source Folder";
            this.ToolTip.SetToolTip(this.SourceFolder, "Put the images you want to sort here");
            this.SourceFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SourceFolder.UseAccentColor = false;
            this.SourceFolder.UseVisualStyleBackColor = true;
            this.SourceFolder.Click += new System.EventHandler(this.SourceFolder_Click);
            // 
            // ReloadImages
            // 
            this.ReloadImages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReloadImages.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ReloadImages.Depth = 0;
            this.ReloadImages.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadImages.HighEmphasis = true;
            this.ReloadImages.Icon = global::VisualSorter.Properties.Resources.Reload;
            this.ReloadImages.Location = new System.Drawing.Point(5, 4);
            this.ReloadImages.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ReloadImages.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReloadImages.Name = "ReloadImages";
            this.ReloadImages.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ReloadImages.Size = new System.Drawing.Size(204, 36);
            this.ReloadImages.TabIndex = 0;
            this.ReloadImages.Text = "Load Source Folder";
            this.ToolTip.SetToolTip(this.ReloadImages, "Load the images from the Source Folder");
            this.ReloadImages.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ReloadImages.UseAccentColor = false;
            this.ReloadImages.UseVisualStyleBackColor = true;
            this.ReloadImages.Click += new System.EventHandler(this.ReloadImages_Click);
            // 
            // ImageView
            // 
            this.ImageView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImageView.BackColor = System.Drawing.Color.Transparent;
            this.ImageView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageView.Location = new System.Drawing.Point(0, 126);
            this.ImageView.Name = "ImageView";
            this.ImageView.Size = new System.Drawing.Size(777, 525);
            this.ImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageView.TabIndex = 1;
            this.ImageView.TabStop = false;
            this.ToolTip.SetToolTip(this.ImageView, "Delete the current Image");
            this.ImageView.WaitOnLoad = true;
            // 
            // LabelCount
            // 
            this.LabelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCount.AutoSize = true;
            this.LabelCount.BackColor = System.Drawing.Color.DarkRed;
            this.LabelCount.Depth = 0;
            this.LabelCount.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelCount.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.LabelCount.Location = new System.Drawing.Point(15, 619);
            this.LabelCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(63, 29);
            this.LabelCount.TabIndex = 33;
            this.LabelCount.Text = "0/100";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.ContactButton);
            this.materialCard1.Controls.Add(this.HelpButton);
            this.materialCard1.Controls.Add(this.SaveStateCheckBox);
            this.materialCard1.Controls.Add(this.SortedImages);
            this.materialCard1.Controls.Add(this.SourceFolder);
            this.materialCard1.Controls.Add(this.ReloadImages);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1157, 45);
            this.materialCard1.TabIndex = 34;
            // 
            // ContactButton
            // 
            this.ContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContactButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ContactButton.Depth = 0;
            this.ContactButton.HighEmphasis = true;
            this.ContactButton.Icon = global::VisualSorter.Properties.Resources.ContactIcon;
            this.ContactButton.Location = new System.Drawing.Point(911, 4);
            this.ContactButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ContactButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContactButton.Name = "ContactButton";
            this.ContactButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ContactButton.Size = new System.Drawing.Size(117, 36);
            this.ContactButton.TabIndex = 36;
            this.ContactButton.Text = "Contact";
            this.ContactButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ContactButton.UseAccentColor = false;
            this.ContactButton.UseVisualStyleBackColor = true;
            this.ContactButton.Click += new System.EventHandler(this.ContactButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1163, 657);
            this.Controls.Add(this.RemoveFromFolders);
            this.Controls.Add(this.NumInputDown);
            this.Controls.Add(this.NumInputUp);
            this.Controls.Add(this.JumpToImageEnter);
            this.Controls.Add(this.JumpToImage);
            this.Controls.Add(this.TrashButton);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.ImageView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1163, 657);
            this.Name = "Form1";
            this.Text = "Visual Sorter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.RightPanel.ResumeLayout(false);
            this.TopRightPanel.ResumeLayout(false);
            this.TopRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumpToImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox ImageView;
        public System.Windows.Forms.Panel RightPanel;
        public System.Windows.Forms.Panel TopRightPanel;
        public System.Windows.Forms.ToolTip ToolTip;
        public Guna.UI2.WinForms.Guna2Button bttn_Previous;
        public Guna.UI2.WinForms.Guna2Button bttn_Next;
        private Guna.UI2.WinForms.Guna2Button RotateButton;
        private MaterialSkin.Controls.MaterialButton ReloadImages;
        private MaterialSkin.Controls.MaterialButton SourceFolder;
        private MaterialSkin.Controls.MaterialButton SortedImages;
        public MaterialSkin.Controls.MaterialLabel LabelCount;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        public MaterialSkin.Controls.MaterialSwitch SaveStateCheckBox;
        public MaterialSkin.Controls.MaterialCheckbox CategoriesCheckBox;
        public MaterialSkin.Controls.MaterialTextBox InputField;
        public MaterialSkin.Controls.MaterialButton CreateCategoryGroup;
        public System.Windows.Forms.FlowLayoutPanel CategoryButtonsPanel;
        public MaterialSkin.Controls.MaterialButton HelpButton;
        public MaterialSkin.Controls.MaterialButton TrashButton;
        private MaterialSkin.Controls.MaterialButton ContactButton;
        private MaterialSkin.Controls.MaterialButton JumpToImageEnter;
        private System.Windows.Forms.Button NumInputUp;
        private System.Windows.Forms.Button NumInputDown;
        public Guna.UI2.WinForms.Guna2NumericUpDown JumpToImage;
        public MaterialSkin.Controls.MaterialButton RemoveFromFolders;
    }
}

