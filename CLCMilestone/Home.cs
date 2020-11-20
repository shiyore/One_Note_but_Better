using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLCMilestone
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calandar_Click(object sender, EventArgs e)
        {
            MainNotePage notesHome = new MainNotePage();
            //this.Hide();
            notesHome.Show();
        }

        private void btn_calendar_Click(object sender, EventArgs e)
        {
            ViewCalender calender = new ViewCalender();
            calender.Show();
        }
    }
}
