using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tour_agency1
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            dataGridView6.Rows.Clear();
            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();

            string query = "SELECT * FROM client";

            MySqlCommand command = new MySqlCommand(query);
            command.Connection = connection;
            command.CommandText = query;

            using (DbDataReader reader = command.ExecuteReader())
            {
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();

                }

                reader.Close();
                connection.Close();

                foreach (string[] s in data)
                    dataGridView6.Rows.Add(s);
            }
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();

            string query = "SELECT * FROM payment";

            MySqlCommand command = new MySqlCommand(query);
            command.Connection = connection;
            command.CommandText = query;

            using (DbDataReader reader = command.ExecuteReader())
            {
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();

                }

                reader.Close();
                connection.Close();

                foreach (string[] s in data)
                    dataGridView2.Rows.Add(s);
            }
        }

        private void addExcursionButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `tour_agency`.`excursion` (`ex_name`, `description`, `country`, `city`, `ex_date`, `number_of_people`, `ex_duration`, `price`) VALUES (@name, @description, @country, @city, @date, @numberOfPeople, @duration, @price)", connection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = ex_name.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = ex_description.Text;
            command.Parameters.Add("@country", MySqlDbType.VarChar).Value = country.Text;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city.Text;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = ex_date.Text;
            command.Parameters.Add("@numberOfPeople", MySqlDbType.VarChar).Value = number_of_people.Text;
            command.Parameters.Add("@duration", MySqlDbType.VarChar).Value = duration.Text;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price.Text;


            connection.Open();
            if (ex_date.Text == "" && ex_description.Text == "" && country.Text == "" && city.Text == "" && ex_date.Text == "" && number_of_people.Text == "" && duration.Text == "" && price.Text == "")
                MessageBox.Show("Спершу введіть дані");
            else if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Екскурсію було додано");
            
            else
                MessageBox.Show("Екскурсію не додано");
            connection.Close();
        }

        private void goBackToMainPage_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showExcursionButton_Click(object sender, EventArgs e)
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

        private void showHotelButton_Click(object sender, EventArgs e)
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

        private void showTourButton_Click(object sender, EventArgs e)
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

        private void addHotelButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `tour_agency`.`hotel` (`hotel_name`, `description`, `hotel_country`, `adress`, `stars`, `type_of_room`, `amount_of_people`, `price`) VALUES (@name, @description, @country, @adress, @stars, @typeOfRoom, @numberOfPeople, @price)", connection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = hotel_name.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = hotel_descr.Text;
            command.Parameters.Add("@country", MySqlDbType.VarChar).Value = hotel_country.Text;
            command.Parameters.Add("@adress", MySqlDbType.VarChar).Value = hotel_adress.Text;
            command.Parameters.Add("@stars", MySqlDbType.Int16).Value = hotel_stars.Text;
            command.Parameters.Add("@typeofRoom", MySqlDbType.VarChar).Value = type_of_room.Text;
            command.Parameters.Add("@numberOfPeople", MySqlDbType.Int16).Value = amount_of_people.Text;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = hotel_price.Text;


            connection.Open();
            if (hotel_name.Text == "" && hotel_descr.Text == "" && hotel_country.Text == "" && hotel_adress.Text == "" && hotel_stars.Text == "" && type_of_room.Text == "" && duration.Text == "" && amount_of_people.Text == "" && hotel_price.Text=="")
                MessageBox.Show("Спершу введіть дані");
            else if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Готель було додано");
            else
                MessageBox.Show("Готель не додано");
            connection.Close();
        }

        private void addTourButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `tour_agency`.`tour` (`tour_name`, `tour_description`, `country`, `city`, `start_date`, `end_date`, `number_of_people`,`type`, `price`) VALUES (@name, @description, @country, @city, @start, @end, @numberOfPeople, @type, @price)", connection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = tour_name.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = tour_descr.Text;
            command.Parameters.Add("@country", MySqlDbType.VarChar).Value = tour_country.Text;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = tour_city.Text;
            command.Parameters.Add("@start", MySqlDbType.Date).Value = start_date.Text;
            command.Parameters.Add("@end", MySqlDbType.Date).Value = end_date.Text;
            command.Parameters.Add("@numberOfPeople", MySqlDbType.Int16).Value = numbepeople.Text;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = tour_type.Text;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = tour_price.Text;


            connection.Open();
            if (tour_name.Text == "" && tour_descr.Text == "" && tour_country.Text == "" && tour_city.Text == "" && start_date.Text == "" && end_date.Text == "" && numbepeople.Text == "" && tour_type.Text == "" && tour_price.Text == "")
                MessageBox.Show("Спершу введіть дані");
            else if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Тур було додано");
            else
                MessageBox.Show("Тур не додано");
            connection.Close();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void label28_Click(object sender, EventArgs e)
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
        Point lastPoint;
        private void adminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void adminForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void deleteExcursionButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `tour_agency`.`excursion` WHERE `id_excursion`=@id", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = deleteExTB.Text;
            connection.Open();
            if (deleteExTB.Text=="")
                MessageBox.Show("Спершу введіть дані");
            else if (command.ExecuteNonQuery() == 0)
                MessageBox.Show("Не видалено");
            else
                MessageBox.Show("Екскурсію було видалено");
            connection.Close();
        }

        private void deleteTourButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `tour_agency`.`tour` WHERE `id_tour`=@id", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = deleteTourTB.Text;
            
            connection.Open();
            if (deleteTourTB.Text == "")
                MessageBox.Show("Спершу введіть дані");
            else if (command.ExecuteNonQuery() == 0)
                MessageBox.Show("Не видалено");
            else
                MessageBox.Show("Тур було видалено");
            connection.Close();
        }

        private void deleteHotelButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `tour_agency`.`hotel` WHERE `id_hotel`=@id", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = deleteHotelTB.Text;
            connection.Open();
            if (deleteHotelTB.Text == "")
                MessageBox.Show("Спершу введіть дані");
            else if (command.ExecuteNonQuery() == 0)
                MessageBox.Show("Не видалено");
            else
                MessageBox.Show("Готель було видалено");
            connection.Close();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
