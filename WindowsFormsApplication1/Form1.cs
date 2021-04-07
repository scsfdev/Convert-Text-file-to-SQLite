using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SQLiteConnection sql_con;

        class Item
        {
            public Int64 col1 { get; set; }
            public int col2 { get; set; }
            public string col3 { get; set; }
            public int col4 { get; set; }
            public int col5 { get; set; }
            public int col6 { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            txtDB.Text = @"C:\Software\SampleDB.db";
            txtCSV.Text = @"C:\Software\wmitems.txt";

            SetConnection();
        }

        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                (@"Data Source=" + txtDB.Text + ";Version=3;New=False;Compress=True;");

        }

        int ToInt32(object obj)
        {
            int iOut = 0;
            if (obj is DBNull || obj == null)
                return 0;

            if (int.TryParse(obj.ToString().Trim(), out iOut))
                return iOut;
            else
                return 0;
        }

        Int64 ToInt64(object obj)
        {
            if (obj is DBNull || obj == null)
                return 0;

            Int64 iOut64 = Convert.ToInt64(obj.ToString().Trim());

            return iOut64;
        }

        private void btnMethod1_Click(object sender, EventArgs e)
        {
            lblMethod1.Text = "Start Time: " + DateTime.Now.ToString("hh:mm:ss");
            Method1();
            lblMethod1.Text += ". End Time: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void Method1()
        {
            try
            {
                sql_con.Open();
                Console.WriteLine("Start: " + DateTime.Now);
                var lines = File.ReadAllLines(txtCSV.Text);
                foreach (var line in lines)
                {
                    Item i = new Item();
                    i.col1 = ToInt64(line.Substring(0, 15));
                    i.col2 = ToInt32(line.Substring(15, 9));
                    i.col3 = line.Substring(24, 35).Trim().Replace("\"", "");
                    i.col4 = ToInt32(line.Substring(59, 10));
                    i.col5 = ToInt32(line.Substring(69, 10));
                    i.col6 = ToInt32(line.Substring(79, 5));

                    Insert(i);
                }

                Console.WriteLine("End: " + DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                sql_con.Close();
            }
        }

        
        void Insert(Item i)
        {
            
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO master (col1,col2,col3,col4,col5,col6) VALUES (?,?,?,?,?,?)", sql_con);
            insertSQL.Parameters.AddWithValue("col1",i.col1);
            insertSQL.Parameters.AddWithValue("col2", i.col2);
            insertSQL.Parameters.AddWithValue("col3", i.col3);
            insertSQL.Parameters.AddWithValue("col4", i.col4);
            insertSQL.Parameters.AddWithValue("col5", i.col5);
            insertSQL.Parameters.AddWithValue("col6", i.col6);

            try
            {
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }


        

        private void btnMethod2_Click(object sender, EventArgs e)
        {
            lblMethod2.Text = "Start Time: " + DateTime.Now.ToString("hh:mm:ss");
            Method2();
            lblMethod2.Text += ". End Time: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void Method2()
        {
            sql_con.Open();
            SQLiteCommand command = sql_con.CreateCommand();
            SQLiteTransaction transaction = sql_con.BeginTransaction();

            command.CommandText = "INSERT INTO Master "
                                    + "(col1, col2, col3, col4, col5, col6) " +
                                    "VALUES (@col1, @col2, @col3, @col4, @col5, @col6)";

            command.Parameters.AddWithValue("@col1", "");
            command.Parameters.AddWithValue("@col2", "");
            command.Parameters.AddWithValue("@col3", "");
            command.Parameters.AddWithValue("@col4", "");
            command.Parameters.AddWithValue("@col5", "");
            command.Parameters.AddWithValue("@col6", "");

            var lines = File.ReadAllLines(txtCSV.Text);
            foreach (var line in lines)
            {
                InsertResultItem(ToInt64(line.Substring(0, 15)), ToInt32(line.Substring(15, 9)), line.Substring(24, 35).Trim().Replace("\"", ""),
                                 ToInt32(line.Substring(59, 10)), ToInt32(line.Substring(69, 10)), ToInt32(line.Substring(79, 5)), command);
            }

            transaction.Commit();
            command.Dispose();
         //   sql_con.Dispose();
        }

        private int InsertResultItem(Int64 col1, int col2, string col3, int col4, int col5, int col6, SQLiteCommand command)
        {
            command.Parameters["@col1"].Value = col1;
            command.Parameters["@col2"].Value = col2;
            command.Parameters["@col3"].Value = col3;
            command.Parameters["@col4"].Value = col4;
            command.Parameters["@col5"].Value = col5;
            command.Parameters["@col6"].Value = col6;
            return command.ExecuteNonQuery();
        }
    }
}
