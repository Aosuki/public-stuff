using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            if (!panel2.Controls.Contains(testcon3.Instance))
            {
                panel2.Controls.Add(testcon3.Instance);
                testcon3.Instance.Dock = DockStyle.Fill;
                testcon3.Instance.BringToFront();
            }
            else testcon3.Instance.BringToFront();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            if (!panel2.Controls.Contains(testcon2.Instance))
            {
                panel2.Controls.Add(testcon2.Instance);
                testcon2.Instance.Dock = DockStyle.Fill;
                testcon2.Instance.BringToFront();
            }
            else testcon2.Instance.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
                pictureBox1.BringToFront();
            }
            else if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            if (!panel2.Controls.Contains(testcon1.Instance))
            {
                panel2.Controls.Add(testcon1.Instance);
                testcon1.Instance.Dock = DockStyle.Fill;
                testcon1.Instance.BringToFront();
            }
            else testcon1.Instance.BringToFront();
        }
    }
}
