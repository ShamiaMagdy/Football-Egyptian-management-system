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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-726I30C;Initial Catalog=Football Egyption Management System;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand cmd = new SqlCommand("ADMIN_Login1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", textBox1.Text);
            cmd.Parameters.Add("@password", textBox2.Text);
            SqlDataReader reader =cmd.ExecuteReader();
            if(reader.Read())
            {*/
                Admin_Functions frm = new Admin_Functions();
                frm.ShowDialog();
                this.Hide();
            //}
        }
    }
}
