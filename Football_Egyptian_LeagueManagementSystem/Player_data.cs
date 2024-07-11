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
    public partial class Player_data : Form
    {
        public Player_data()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-726I30C;Initial Catalog=Football Egyption Management System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("ADD_player",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", textBox1.Text);
            cmd.Parameters.Add("@name", textBox2.Text);
            cmd.Parameters.Add("@S_num", textBox3.Text);
            cmd.Parameters.Add("@Team_id", textBox4.Text);
            cmd.Parameters.Add("@pos_id", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Done !!");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-726I30C;Initial Catalog=Football Egyption Management System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Edit_player", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", textBox1.Text);
            cmd.Parameters.Add("@name", textBox2.Text);
            cmd.Parameters.Add("@S_num", textBox3.Text);
            cmd.Parameters.Add("@Team_id", textBox4.Text);
            cmd.Parameters.Add("@pos_id", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();

        }
    }
}
