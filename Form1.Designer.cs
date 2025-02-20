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
            label1 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            but_Profile = new FontAwesome.Sharp.IconButton();
            but_Menu = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panel = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panelMenu.SuspendLayout();
            panel.SuspendLayout();
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
            panelMenu.Location = new Point(0, 30);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(180, 420);
            panelMenu.TabIndex = 0;
            panelMenu.Tag = "0";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(0, 405);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 4;
            label1.Text = "v0.1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            iconButton3.Location = new Point(0, 166);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(5, 0, 10, 0);
            iconButton3.Size = new Size(180, 50);
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
            but_Profile.Location = new Point(0, 116);
            but_Profile.Name = "but_Profile";
            but_Profile.Padding = new Padding(5, 0, 10, 0);
            but_Profile.Size = new Size(180, 50);
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
            but_Menu.Location = new Point(0, 66);
            but_Menu.Name = "but_Menu";
            but_Menu.Padding = new Padding(5, 0, 10, 0);
            but_Menu.Size = new Size(180, 50);
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
            panelLogo.Size = new Size(180, 66);
            panelLogo.TabIndex = 0;
            // 
            // panel
            // 
            panel.AccessibleRole = AccessibleRole.MenuBar;
            panel.AllowDrop = true;
            panel.BackColor = Color.FromArgb(0, 64, 64);
            panel.Controls.Add(iconButton4);
            panel.Controls.Add(iconButton2);
            panel.Controls.Add(iconButton1);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(4);
            panel.Size = new Size(800, 30);
            panel.TabIndex = 1;
            panel.Tag = "1";
            panel.MouseDown += panel_MouseDown;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 2;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.MintCream;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton1.IconColor = Color.MintCream;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 24;
            iconButton1.Location = new Point(774, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(0, 2, 0, 0);
            iconButton1.Size = new Size(22, 22);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Right;
            iconButton2.FlatAppearance.BorderSize = 2;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.MintCream;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton2.IconColor = Color.MintCream;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 24;
            iconButton2.Location = new Point(752, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(0, 2, 0, 0);
            iconButton2.Size = new Size(22, 22);
            iconButton2.TabIndex = 1;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Right;
            iconButton4.FlatAppearance.BorderSize = 2;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.MintCream;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton4.IconColor = Color.MintCream;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 24;
            iconButton4.Location = new Point(730, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(0, 2, 0, 0);
            iconButton4.Size = new Size(22, 22);
            iconButton4.TabIndex = 2;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton but_Menu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton but_Profile;
        private Label label1;
        private Panel panel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
