using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Football_Egyptian_LeagueManagementSystem
{
    public partial class fans_Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-726I30C;Initial Catalog=Football Egyption Management System;Integrated Security=True"); 
        public fans_Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@User_N",textBox2.Text);
            cmd.Parameters.Add("@EMail", textBox1.Text);
            cmd.Parameters.Add("@pass", textBox3.Text);
            cmd.Parameters.Add("@team_id", textBox4.Text);
            cmd.Parameters.Add("@fix_id", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Registeration is Done :):)");

        }
    }
}
