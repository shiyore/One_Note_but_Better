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
    public partial class ViewCalender : Form
    {

        NoteService service;
        public ViewCalender()
        {
            InitializeComponent();
        }
        public ViewCalender(NoteService service)
        {
            InitializeComponent();
            this.service = service;
        }



        private void ViewCalender_Load(object sender, EventArgs e)
        {
            foreach (Note n in service.notes)
            {
                if (n.date.DayOfWeek == DayOfWeek.Monday)
                    mondayTextBox.Text = mondayTextBox.Text + n.get_message() + "\n";
                else if (n.date.DayOfWeek == DayOfWeek.Tuesday)
                    tuesdayTextBox1.Text = tuesdayTextBox1.Text + n.get_message() + "\n";
                else if (n.date.DayOfWeek == DayOfWeek.Wednesday)
                    wednesdayTextBox.Text = wednesdayTextBox.Text + n.get_message() + "\n";
                else if (n.date.DayOfWeek == DayOfWeek.Thursday)
                    thursdayTextBox.Text = thursdayTextBox + n.get_message() + "\n";
                else if (n.date.DayOfWeek == DayOfWeek.Friday)
                    fridayTextBox.Text = fridayTextBox.Text + n.get_message() + "\n";
                else if (n.date.DayOfWeek == DayOfWeek.Saturday)
                    saturdayTextBox.Text = saturdayTextBox.Text + n.get_message() + "\n";
                else if (n.date.DayOfWeek == DayOfWeek.Sunday)
                    sundayTextBox.Text = sundayTextBox.Text + n.get_message() + "\n";


            }
        }

        private void Btn_BackIcon_Click(object sender, EventArgs e)
        {
            Home backHome = new Home();
            backHome.Show();
            this.Visible = false;

        }

        private void NewNoteIconbtn_Click(object sender, EventArgs e)
        {
            Note new_note = new Note();
            NewNote note_page = new NewNote(service, new_note);
            note_page.Show();
            this.Visible = false;
        }

        private void mondayTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
