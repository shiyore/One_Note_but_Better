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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ViewCalender_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Note new_note = new Note();
            NewNote note_page = new NewNote(service, new_note);

            note_page.Show();
        }
    }
}
