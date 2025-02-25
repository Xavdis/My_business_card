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
            b_myProjects = new FontAwesome.Sharp.IconButton();
            b_Profile = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            b_menu = new FontAwesome.Sharp.IconButton();
            panel = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            b_minWindow = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkSlateGray;
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(b_myProjects);
            panelMenu.Controls.Add(b_Profile);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 18);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(180, 432);
            panelMenu.TabIndex = 0;
            panelMenu.Tag = "0";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(0, 417);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 4;
            label1.Text = "v0.2";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // b_myProjects
            // 
            b_myProjects.Cursor = Cursors.Hand;
            b_myProjects.Dock = DockStyle.Top;
            b_myProjects.FlatAppearance.BorderSize = 0;
            b_myProjects.FlatStyle = FlatStyle.Flat;
            b_myProjects.ForeColor = Color.MintCream;
            b_myProjects.IconChar = FontAwesome.Sharp.IconChar.FileText;
            b_myProjects.IconColor = Color.MintCream;
            b_myProjects.IconFont = FontAwesome.Sharp.IconFont.Auto;
            b_myProjects.IconSize = 28;
            b_myProjects.ImageAlign = ContentAlignment.MiddleLeft;
            b_myProjects.Location = new Point(0, 105);
            b_myProjects.Name = "b_myProjects";
            b_myProjects.Padding = new Padding(5, 0, 10, 0);
            b_myProjects.Size = new Size(180, 50);
            b_myProjects.TabIndex = 3;
            b_myProjects.Text = "My projects";
            b_myProjects.TextAlign = ContentAlignment.MiddleLeft;
            b_myProjects.TextImageRelation = TextImageRelation.ImageBeforeText;
            b_myProjects.UseVisualStyleBackColor = true;
            // 
            // b_Profile
            // 
            b_Profile.Cursor = Cursors.Hand;
            b_Profile.Dock = DockStyle.Top;
            b_Profile.FlatAppearance.BorderSize = 0;
            b_Profile.FlatStyle = FlatStyle.Flat;
            b_Profile.ForeColor = Color.MintCream;
            b_Profile.IconChar = FontAwesome.Sharp.IconChar.FaceLaughBeam;
            b_Profile.IconColor = Color.MintCream;
            b_Profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            b_Profile.IconSize = 28;
            b_Profile.ImageAlign = ContentAlignment.MiddleLeft;
            b_Profile.Location = new Point(0, 55);
            b_Profile.Name = "b_Profile";
            b_Profile.Padding = new Padding(5, 0, 10, 0);
            b_Profile.Size = new Size(180, 50);
            b_Profile.TabIndex = 2;
            b_Profile.Text = "Profile";
            b_Profile.TextAlign = ContentAlignment.MiddleLeft;
            b_Profile.TextImageRelation = TextImageRelation.ImageBeforeText;
            b_Profile.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(b_menu);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(180, 55);
            panelLogo.TabIndex = 0;
            // 
            // b_menu
            // 
            b_menu.Cursor = Cursors.Hand;
            b_menu.Dock = DockStyle.Top;
            b_menu.FlatAppearance.BorderSize = 0;
            b_menu.FlatStyle = FlatStyle.Flat;
            b_menu.ForeColor = Color.MintCream;
            b_menu.IconChar = FontAwesome.Sharp.IconChar.MapSigns;
            b_menu.IconColor = Color.MintCream;
            b_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            b_menu.IconSize = 43;
            b_menu.ImageAlign = ContentAlignment.MiddleLeft;
            b_menu.Location = new Point(0, 0);
            b_menu.Name = "b_menu";
            b_menu.Padding = new Padding(5, 0, 10, 0);
            b_menu.Size = new Size(180, 50);
            b_menu.TabIndex = 2;
            b_menu.Text = "Menu";
            b_menu.TextAlign = ContentAlignment.MiddleLeft;
            b_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            b_menu.UseVisualStyleBackColor = true;
            b_menu.Click += b_menu_click;
            // 
            // panel
            // 
            panel.AccessibleRole = AccessibleRole.MenuBar;
            panel.AllowDrop = true;
            panel.BackColor = Color.FromArgb(0, 64, 64);
            panel.Controls.Add(iconButton4);
            panel.Controls.Add(b_minWindow);
            panel.Controls.Add(iconButton1);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(800, 18);
            panel.TabIndex = 1;
            panel.Tag = "1";
            panel.MouseDown += panel_MouseDown;
            panel.MouseMove += panel_MouseMove;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Right;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.MintCream;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton4.IconColor = Color.MintCream;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 15;
            iconButton4.Location = new Point(710, 0);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(30, 18);
            iconButton4.TabIndex = 5;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // b_minWindow
            // 
            b_minWindow.Dock = DockStyle.Right;
            b_minWindow.FlatAppearance.BorderSize = 0;
            b_minWindow.FlatStyle = FlatStyle.Flat;
            b_minWindow.ForeColor = Color.MintCream;
            b_minWindow.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            b_minWindow.IconColor = Color.MintCream;
            b_minWindow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            b_minWindow.IconSize = 15;
            b_minWindow.Location = new Point(740, 0);
            b_minWindow.Name = "b_minWindow";
            b_minWindow.Padding = new Padding(0, 2, 0, 0);
            b_minWindow.Size = new Size(30, 18);
            b_minWindow.TabIndex = 6;
            b_minWindow.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.MintCream;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton1.IconColor = Color.MintCream;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 15;
            iconButton1.Location = new Point(770, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(0, 2, 0, 0);
            iconButton1.Size = new Size(30, 18);
            iconButton1.TabIndex = 7;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click_1;
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
            panelLogo.ResumeLayout(false);
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton b_myProjects;
        private FontAwesome.Sharp.IconButton b_Profile;
        private Label label1;
        private Panel panel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton b_minWindow;
        private FontAwesome.Sharp.IconButton b_menu;
    }
}
