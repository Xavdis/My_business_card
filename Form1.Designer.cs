namespace My_business_card
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            but_Profile = new FontAwesome.Sharp.IconButton();
            but_Menu = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkSlateGray;
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(but_Profile);
            panelMenu.Controls.Add(but_Menu);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // iconButton3
            // 
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.MintCream;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Virus;
            iconButton3.IconColor = Color.MintCream;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 240);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(5, 0, 10, 0);
            iconButton3.Size = new Size(220, 50);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "My projects";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // but_Profile
            // 
            but_Profile.Cursor = Cursors.Hand;
            but_Profile.Dock = DockStyle.Top;
            but_Profile.FlatAppearance.BorderSize = 0;
            but_Profile.FlatStyle = FlatStyle.Flat;
            but_Profile.ForeColor = Color.MintCream;
            but_Profile.IconChar = FontAwesome.Sharp.IconChar.Virus;
            but_Profile.IconColor = Color.MintCream;
            but_Profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            but_Profile.ImageAlign = ContentAlignment.MiddleLeft;
            but_Profile.Location = new Point(0, 190);
            but_Profile.Name = "but_Profile";
            but_Profile.Padding = new Padding(5, 0, 10, 0);
            but_Profile.Size = new Size(220, 50);
            but_Profile.TabIndex = 2;
            but_Profile.Text = "Profile";
            but_Profile.TextAlign = ContentAlignment.MiddleLeft;
            but_Profile.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Profile.UseVisualStyleBackColor = true;
            // 
            // but_Menu
            // 
            but_Menu.Cursor = Cursors.Hand;
            but_Menu.Dock = DockStyle.Top;
            but_Menu.FlatAppearance.BorderSize = 0;
            but_Menu.FlatStyle = FlatStyle.Flat;
            but_Menu.ForeColor = Color.MintCream;
            but_Menu.IconChar = FontAwesome.Sharp.IconChar.Virus;
            but_Menu.IconColor = Color.MintCream;
            but_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            but_Menu.ImageAlign = ContentAlignment.MiddleLeft;
            but_Menu.Location = new Point(0, 140);
            but_Menu.Name = "but_Menu";
            but_Menu.Padding = new Padding(5, 0, 10, 0);
            but_Menu.Size = new Size(220, 50);
            but_Menu.TabIndex = 1;
            but_Menu.Text = "Menu";
            but_Menu.TextAlign = ContentAlignment.MiddleLeft;
            but_Menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Menu.UseVisualStyleBackColor = true;
            but_Menu.Click += iconButton1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(0, 435);
            label1.Name = "label1";
            label1.Size = new Size(220, 15);
            label1.TabIndex = 4;
            label1.Text = "v0.1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton but_Menu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton but_Profile;
        private Label label1;
    }
}
