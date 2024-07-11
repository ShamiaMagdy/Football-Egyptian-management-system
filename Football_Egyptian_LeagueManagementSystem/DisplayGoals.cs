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
    public partial class DisplayGoals : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-726I30C;Initial Catalog=Football Egyption Management System;Integrated Security=True");
        
        public DisplayGoals()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Display_goals", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@fix_ID", textBox1.Text);
            cmd.Parameters.Add("@P_ID", textBox2.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Columns.Add("Name");
            DT.Columns.Add("Scored_Goals");
            DataRow R;
            while (reader.Read())
            {
                R = DT.NewRow();
                R["Name"] = reader["Name"];
                R["Scored_Goals"] = reader["Scored_Goals"];
                DT.Rows.Add(R);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = DT;
        }
    }
}
