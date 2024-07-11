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
    public partial class taem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-726I30C;Initial Catalog=Football Egyption Management System;Integrated Security=True"); 
        public taem()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("AD_team1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", textBox1.Text);
            cmd.Parameters.Add("@name", textBox2.Text);
            cmd.Parameters.Add("@fix_id", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added successfully ^_^");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Edit_team", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", textBox1.Text);
            cmd.Parameters.Add("@name", textBox2.Text);
            cmd.Parameters.Add("@fix_id", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated successfully ^_^");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete_team", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted successfully ^_^");
        }
    }
}
