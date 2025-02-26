using System.Runtime;
using System.Text;

namespace My_business_card
{
    public partial class Form1 : Form
    {
        public Point currentMousPos;
        public Form1()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            currentMousPos = new Point(-e.X, -e.Y);

        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouseLoc = Control.MousePosition;
                mouseLoc.Offset(currentMousPos.X, currentMousPos.Y);
                Location = mouseLoc;
            }
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btn_MinMaxWind_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panelMenu.Height += 10;
                if (panelMenu.Height >= 180)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
            else
            {
                panelMenu.Height -= 10;
                if (panelMenu.Height <= 53)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
