using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnect
{
    public partial class Form1 : Form
    {
        OracleConnection ConnectionToOracle;
        //string connectionString = "DATA SOURCE=localhost;PASSWORD=sysdba;PERSIST SECURITY INFO=True;USER ID=system";
        //string connectionString = "Data Source=127.0.0.1:1521/orcl;User Id=system;Password=sysdba";
        string connectionString = "Data Source=127.0.0.1:1521;User Id=HR;Password=ORA17";
        public Form1()
        {
            InitializeComponent();
            ConnectionToOracle = new OracleConnection(connectionString);
            ConnectionToOracle.Open();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.EMPLOYEES". При необходимости она может быть перемещена или удалена.
            this.eMPLOYEESTableAdapter.Fill(this.dataSet1.EMPLOYEES);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            Object returnValue;
            int bookID = Convert.ToInt32(textBox2.Text);
            //команда запроса. Не забываем, что при запросе к БД
            //Oracle все названия пишутся в кавычках
            cmd.CommandText = "SELECT \"LAST_NAME\" FROM \"EMPLOYEES\" WHERE \"EMPLOYEES\".\"EMPLOYEE_ID\" = '" + bookID + "'";
            cmd.Connection = ConnectionToOracle;
            returnValue = cmd.ExecuteScalar();
            textBox1.Text = Convert.ToString(returnValue);

        }
        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            ConnectionToOracle.Close();
        }
    }
}
