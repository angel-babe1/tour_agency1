using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace tour_agency1
{
    public partial class clientChoises : Form
    {
        public clientChoises()
        {
            InitializeComponent();

            passportField.Text = "Введіть дані паспорта"; passportField.ForeColor = Color.Gray;
            dataField.Text = "Введіть дату (рр-мм-дд)"; dataField.ForeColor = Color.Gray;
            summaField.Text = "Введіть суму"; summaField.ForeColor = Color.Gray;
            tourField.Text = "id туру"; tourField.ForeColor = Color.Gray;
            excursionField.Text = "id екскурсії"; excursionField.ForeColor = Color.Gray;
            hotelField.Text = "id готелю"; hotelField.ForeColor = Color.Gray;
        }

        private void showHotels_Click(object sender, EventArgs e)
        {
            dataGridView5.Rows.Clear();
            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();

            string query = "SELECT * FROM hotel";

            MySqlCommand command = new MySqlCommand(query);
            command.Connection = connection;
            command.CommandText = query;

            using (DbDataReader reader = command.ExecuteReader())
            {
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[9]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();

                }

                reader.Close();
                connection.Close();

                foreach (string[] s in data)
                    dataGridView5.Rows.Add(s);
            }
        }

        private void showTour_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();

            string query = "SELECT * FROM tour";

            MySqlCommand command = new MySqlCommand(query);            
            command.Connection = connection;
            command.CommandText = query;

            using (DbDataReader reader = command.ExecuteReader())
            {
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[10]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();

                }

                reader.Close();
                connection.Close();

                foreach (string[] s in data)
                    dataGridView4.Rows.Add(s);
            }
        }

        private void showExcursion_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();

            string query = "SELECT * FROM excursion";

            MySqlCommand command = new MySqlCommand(query);
            command.Connection = connection;
            command.CommandText = query;

            using (DbDataReader reader = command.ExecuteReader())
            {
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[9]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();

                }

                reader.Close();
                connection.Close();

                foreach (string[] s in data)
                    dataGridView3.Rows.Add(s);
            }
        }

        private void chooseHotel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void chooseTour_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void chooseExcursion_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientForm clientform = new clientForm();
            clientform.Show();
        }


        Point lastPoint;

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tourField_Enter(object sender, EventArgs e)
        {
            if (tourField.Text == "id туру")
            {
                tourField.Text = "";
                tourField.ForeColor = Color.Black;
            }
        }

        private void passportField_Enter(object sender, EventArgs e)
        {
            if (passportField.Text == "Введіть дані паспорта")
            {
                passportField.Text = "";
                passportField.ForeColor = Color.Black;
            }
        }

        private void passportField_Leave(object sender, EventArgs e)
        {
            if (passportField.Text == "")
            {
                passportField.Text = "Введіть дані паспорта";
                passportField.ForeColor = Color.Gray;
            }
        }

        private void dataField_Enter(object sender, EventArgs e)
        {
            if (dataField.Text == "Введіть дату (рр-мм-дд)")
            {
                dataField.Text = "";
                dataField.ForeColor = Color.Black;
            }
        }

        private void dataField_Leave(object sender, EventArgs e)
        {
            if (dataField.Text == "")
            {
                dataField.Text = "Введіть дату (рр-мм-дд)"; 
                dataField.ForeColor = Color.Gray;
            }
        }

        private void summaField_Enter(object sender, EventArgs e)
        {
            if (summaField.Text == "Введіть суму")
            {
                summaField.Text = "";
                summaField.ForeColor = Color.Black;
            }
        }

        private void summaField_Leave(object sender, EventArgs e)
        {
            if (summaField.Text == "")
            {
                summaField.Text = "Введіть суму";
                summaField.ForeColor = Color.Gray;
            }
        }

        private void tourField_Leave(object sender, EventArgs e)
        {
            if (tourField.Text == "")
            {
                tourField.Text = "id туру";
                tourField.ForeColor = Color.Gray;
            }
        }

        private void excursionIdField_Leave(object sender, EventArgs e)
        {
            if (excursionField.Text == "")
            {
                excursionField.Text = "id екскурсії";
                excursionField.ForeColor = Color.Gray;
            }
        }

        private void excursionIdField_Enter(object sender, EventArgs e)
        {
            if (excursionField.Text == "id екскурсії")
            {
                excursionField.Text = "";
                excursionField.ForeColor = Color.Black;
            }
        }

        private void hotelIdField_Enter(object sender, EventArgs e)
        {
            if (hotelField.Text == "id готелю")
            {
                hotelField.Text = "";
                hotelField.ForeColor = Color.Black;
            }
        }

        private void hotelIdField_Leave(object sender, EventArgs e)
        {
            if (hotelField.Text == "")
            {
                hotelField.Text = "id готелю";
                hotelField.ForeColor = Color.Gray;
            }
        }
   
        private void clientChoises_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void clientChoises_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `payment` (`date`, `payed_amount`, `client_passport`, `id_tour`, `id_excusrion`, `id_hotel`) VALUES (@date, @summa, @pass, @id_tour, @id_ex, @id_hotel)", connection);
            command.Parameters.Add("@date", MySqlDbType.Date).Value = dataField.Text;
            command.Parameters.Add("@summa", MySqlDbType.Decimal).Value = summaField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passportField.Text;
            command.Parameters.Add("@id_tour", MySqlDbType.Int16).Value = tourField.Text;
            command.Parameters.Add("@id_ex", MySqlDbType.Int16).Value = excursionField.Text;
            command.Parameters.Add("@it_hotel", MySqlDbType.Int16).Value = hotelField.Text;

            connection.Open();
            if (dataField.Text == "" || summaField.Text == "" || passportField.Text == "")
                MessageBox.Show("Спочатку заповніть клієнтські дані");
            else if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Оплата була успішною");
            else
                MessageBox.Show("Спробуйте ще раз");
            connection.Close();
        }
    }
}
