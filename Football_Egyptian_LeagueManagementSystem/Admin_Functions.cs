using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Football_Egyptian_LeagueManagementSystem
{
    public partial class Admin_Functions : Form
    {
        public Admin_Functions()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Player_data frm = new Player_data();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            taem frm = new taem();
            frm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DisplayGoals frm = new DisplayGoals();
            frm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
