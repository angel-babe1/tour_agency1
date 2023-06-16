using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_agency1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm adminform = new adminForm();
            adminform.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientForm clientform = new clientForm();
            clientform.Show();
        }

        private void goToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm registerform = new registerForm();
            registerform.Show();
        }

        private void x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
