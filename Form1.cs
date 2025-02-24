using System.Runtime;

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
    }
}
