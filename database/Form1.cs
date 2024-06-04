using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace database
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\YA ALLAH\Documents\baseapp.mdf"";Integrated Security=True;Connect Timeout=30");


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand Cmd = conn.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "inset table1 value('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            Cmd.ExecuteNonQuery();
            MessageBox.Show("your file is recoreded");
            conn.Close();


        }

    }

 
    }
