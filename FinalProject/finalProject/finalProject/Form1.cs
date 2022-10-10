using System.Data;
using System.Data.OleDb;

namespace finalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tableName = textBox1.Text;
            if(textBox1 != null)
            {
                ReadAccessDB(tableName); 
            }
        }
        public void ReadAccessDB(String name)
        {
            //database connection string
            String connStr = @"Provider=Microsoft.ACE.OLEDB.12.0; 
                             Data Source = C:\Users\GGPC\Documents\Wintec\App Development\FinalProject\farmdatabase.accdb;
                             Persist Security Info = False";
            String query = $"select * from [{name}]"; //sql query to display table information
            OleDbConnection connect = new OleDbConnection(connStr);
            OleDbCommand command = new OleDbCommand(query, connect);
            connect.Open(); //open databse connection using the connection string
            OleDbDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable.DefaultView; //display the table data in dataGridView as a table
        } //end of method
    }
}