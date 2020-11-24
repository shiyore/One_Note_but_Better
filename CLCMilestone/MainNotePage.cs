using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLCMilestone
{
    public partial class MainNotePage : Form
    {
        public NoteService service;
        public MainNotePage(NoteService service)
        {
            InitializeComponent();
            this.service = service;
            notes_list.DataSource = service.notes   ;
            notes_list.DisplayMember = "title";
        }

        private void btn_NewNote_Click(object sender, EventArgs e)
        {
            Note new_note = new Note();
            NewNote note_page = new NewNote(service, new_note);
            note_page.Show();
        }
    }
}
