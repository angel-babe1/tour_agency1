using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            String passportUser = passportField.Text;
            String nameUser = nameField.Text;
            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `client` WHERE `passport` = @pass AND `name` = @name", DBUtils.GetDBConnection());
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passportField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                clientChoises clientchoises = new clientChoises();
                clientchoises.Show();
            }
            else if ((passportField.Text=="") && (nameField.Text==""))
            {
                MessageBox.Show("Потрібно ввести всі дані");
            }
            else
            {
                MessageBox.Show("Спочатку треба зареєструватись");
            }
            connection.Close();

        }


        private void goBackToMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void clientForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void clientForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
