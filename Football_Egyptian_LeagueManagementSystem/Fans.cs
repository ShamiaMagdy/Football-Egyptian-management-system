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
    public partial class Fans : Form
    {
        public Fans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fans_Register frm = new fans_Register();
            this.Hide();
            frm.Show();

        }
    }
}
