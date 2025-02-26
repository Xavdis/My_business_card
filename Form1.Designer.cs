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
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            btn_myProject = new FontAwesome.Sharp.IconButton();
            btn_profile = new FontAwesome.Sharp.IconButton();
            btn_menu = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel = new Panel();
            btn_Minimize = new FontAwesome.Sharp.IconButton();
            btn_MinMaxWind = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            menuTransition = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkSlateGray;
            panelMenu.Controls.Add(btn_myProject);
            panelMenu.Controls.Add(btn_profile);
            panelMenu.Controls.Add(btn_menu);
            panelMenu.Controls.Add(label1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 25);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(180, 425);
            panelMenu.TabIndex = 0;
            panelMenu.Tag = "0";
            // 
            // btn_myProject
            // 
            btn_myProject.Cursor = Cursors.Hand;
            btn_myProject.Dock = DockStyle.Top;
            btn_myProject.FlatAppearance.BorderSize = 0;
            btn_myProject.FlatStyle = FlatStyle.Flat;
            btn_myProject.ForeColor = Color.MintCream;
            btn_myProject.IconChar = FontAwesome.Sharp.IconChar.FileText;
            btn_myProject.IconColor = Color.MintCream;
            btn_myProject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_myProject.IconSize = 28;
            btn_myProject.ImageAlign = ContentAlignment.MiddleLeft;
            btn_myProject.Location = new Point(0, 70);
            btn_myProject.Name = "btn_myProject";
            btn_myProject.Padding = new Padding(5, 0, 10, 0);
            btn_myProject.Size = new Size(180, 35);
            btn_myProject.TabIndex = 5;
            btn_myProject.Text = "My projects";
            btn_myProject.TextAlign = ContentAlignment.MiddleLeft;
            btn_myProject.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_myProject.UseVisualStyleBackColor = true;
            // 
            // btn_profile
            // 
            btn_profile.Cursor = Cursors.Hand;
            btn_profile.Dock = DockStyle.Top;
            btn_profile.FlatAppearance.BorderSize = 0;
            btn_profile.FlatStyle = FlatStyle.Flat;
            btn_profile.ForeColor = Color.MintCream;
            btn_profile.IconChar = FontAwesome.Sharp.IconChar.FaceLaughBeam;
            btn_profile.IconColor = Color.MintCream;
            btn_profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_profile.IconSize = 28;
            btn_profile.ImageAlign = ContentAlignment.MiddleLeft;
            btn_profile.Location = new Point(0, 35);
            btn_profile.Name = "btn_profile";
            btn_profile.Padding = new Padding(5, 0, 10, 0);
            btn_profile.Size = new Size(180, 35);
            btn_profile.TabIndex = 4;
            btn_profile.Text = "Profile";
            btn_profile.TextAlign = ContentAlignment.MiddleLeft;
            btn_profile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_profile.UseVisualStyleBackColor = true;
            // 
            // btn_menu
            // 
            btn_menu.Cursor = Cursors.Hand;
            btn_menu.Dock = DockStyle.Top;
            btn_menu.FlatAppearance.BorderSize = 0;
            btn_menu.FlatStyle = FlatStyle.Flat;
            btn_menu.ForeColor = Color.MintCream;
            btn_menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btn_menu.IconColor = Color.MintCream;
            btn_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_menu.IconSize = 28;
            btn_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_menu.Location = new Point(0, 0);
            btn_menu.Name = "btn_menu";
            btn_menu.Padding = new Padding(5, 0, 10, 0);
            btn_menu.Size = new Size(180, 35);
            btn_menu.TabIndex = 3;
            btn_menu.Text = "Menu";
            btn_menu.TextAlign = ContentAlignment.MiddleLeft;
            btn_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_menu.UseVisualStyleBackColor = true;
            btn_menu.Click += btn_menu_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(0, 410);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 4;
            label1.Text = "v0.3";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            panel.AccessibleRole = AccessibleRole.MenuBar;
            panel.AllowDrop = true;
            panel.BackColor = Color.FromArgb(0, 64, 64);
            panel.Controls.Add(btn_Minimize);
            panel.Controls.Add(btn_MinMaxWind);
            panel.Controls.Add(iconButton1);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(800, 25);
            panel.TabIndex = 1;
            panel.Tag = "1";
            panel.DoubleClick += panel_DoubleClick;
            panel.MouseDown += panel_MouseDown;
            panel.MouseMove += panel_MouseMove;
            // 
            // btn_Minimize
            // 
            btn_Minimize.Cursor = Cursors.Hand;
            btn_Minimize.Dock = DockStyle.Right;
            btn_Minimize.FlatAppearance.BorderSize = 0;
            btn_Minimize.FlatStyle = FlatStyle.Flat;
            btn_Minimize.ForeColor = Color.MintCream;
            btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btn_Minimize.IconColor = Color.MintCream;
            btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Minimize.IconSize = 15;
            btn_Minimize.Location = new Point(710, 0);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(30, 25);
            btn_Minimize.TabIndex = 5;
            btn_Minimize.UseVisualStyleBackColor = true;
            btn_Minimize.Click += btn_Minimize_Click;
            // 
            // btn_MinMaxWind
            // 
            btn_MinMaxWind.Cursor = Cursors.Hand;
            btn_MinMaxWind.Dock = DockStyle.Right;
            btn_MinMaxWind.FlatAppearance.BorderSize = 0;
            btn_MinMaxWind.FlatStyle = FlatStyle.Flat;
            btn_MinMaxWind.ForeColor = Color.MintCream;
            btn_MinMaxWind.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btn_MinMaxWind.IconColor = Color.MintCream;
            btn_MinMaxWind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_MinMaxWind.IconSize = 15;
            btn_MinMaxWind.Location = new Point(740, 0);
            btn_MinMaxWind.Name = "btn_MinMaxWind";
            btn_MinMaxWind.Padding = new Padding(0, 2, 0, 0);
            btn_MinMaxWind.Size = new Size(30, 25);
            btn_MinMaxWind.TabIndex = 6;
            btn_MinMaxWind.UseVisualStyleBackColor = true;
            btn_MinMaxWind.Click += btn_MinMaxWind_Click;
            // 
            // iconButton1
            // 
            iconButton1.Cursor = Cursors.Hand;
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
            iconButton1.Size = new Size(30, 25);
            iconButton1.TabIndex = 7;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += btn_Close_Click_1;
            // 
            // menuTransition
            // 
            menuTransition.Tick += menuTransition_Tick;
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
        private Label label1;
        private Panel panel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_MinMaxWind;
        private System.Windows.Forms.Timer menuTransition;
        private FontAwesome.Sharp.IconButton btn_myProject;
        private FontAwesome.Sharp.IconButton btn_profile;
        private FontAwesome.Sharp.IconButton btn_menu;
    }
}
