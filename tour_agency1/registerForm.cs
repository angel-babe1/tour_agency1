using MySql.Data.MySqlClient;
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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            
            MySqlConnection connection = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `client` (`passport`, `name`, `surname`, `email`, `phone_number`, `date_of_birth`) VALUES (@pas, @name, @surname, @email, @phone, @birth)", connection);
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = enterPassportField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = enterNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = enterSurnameField.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = enterEmailField.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = enterPhoneField.Text;
            command.Parameters.Add("@birth", MySqlDbType.Date).Value = enterBirthDateField.Text;

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Акаунт створено");
            else
                MessageBox.Show("Акаунт не створено");
            connection.Close();
        }

        private void goBackToMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void registerForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;
        private void registerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
