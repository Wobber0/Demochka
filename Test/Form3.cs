using DocumentFormat.OpenXml.Spreadsheet;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Test
{
    public partial class AdminWin : Form
    {

        string connectionString = "Server=localhost;Port=3306;Database=hotelbd;Username=root;Password=root;";
        public AdminWin()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(AdminWin_FormClosing);
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }


        void ShowClienttInGrid(string comm)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = comm;
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            BDGridView.DataSource = table;
            conn.Close();
        }

        private void AdminWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 autor = new Form1();
            autor.Show();
            this.Hide();
        }

        private void UsersMenuItem_Click(object sender, EventArgs e)
        {
            Privet.Visible = false;
            pictureBox1.Visible = false;
            BDGridView.Visible = true;
            SaveBut.Visible = true;
            ReportZone.Visible = false;
            SaveBut.Text = "Сохранить изменения";
            try
            {
                ShowClienttInGrid("SELECT * FROM users");
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            BDGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void ReportMenuItem_Click(object sender, EventArgs e)
        {
            BDGridView.Visible=false;
            Privet.Visible = false;
            pictureBox1.Visible = false;
            ReportZone.Visible = true;
            SaveBut.Visible = true;
            Report.Visible = true ;
            SaveBut.Text = "Сохранить в отдельный документ";
            Report.MaximumSize = new System.Drawing.Size(520, Report.MaximumSize.Height);
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
             if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                 return;
             // получаем выбранный файл
             string filename = saveFileDialog1.FileName;
             // сохраняем текст в файл
             System.IO.File.WriteAllText(filename, Report.Text);
            MessageBox.Show("Отчет был успешно сохранен!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NumberMenuItem_Click(object sender, EventArgs e)
        {
            Privet.Visible = false;
            pictureBox1.Visible = false;
            BDGridView.Visible = true;
            SaveBut.Visible = true;
            ReportZone.Visible = false;
            SaveBut.Text = "Сохранить изменения";
            ShowClienttInGrid("SELECT * FROM number_of_rooms");
            BDGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void StatusMenuItem_Click(object sender, EventArgs e)
        {
            Privet.Visible = false;
            pictureBox1.Visible = false;
            BDGridView.Visible = true;
            SaveBut.Visible = true;
            ReportZone.Visible = false;
            ShowClienttInGrid("SELECT * FROM status_of_rooms");
            BDGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void ClientMenuItem_Click(object sender, EventArgs e)
        {
            Privet.Visible = false;
            pictureBox1.Visible = false;
            BDGridView.Visible = true;
            SaveBut.Visible = true;
            ReportZone.Visible = false;
            ShowClienttInGrid("SELECT * FROM clients");
            BDGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
    }