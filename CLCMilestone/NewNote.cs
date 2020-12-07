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
    public partial class NewNote : Form
    {
        private Note note;
        private NoteService service;
        public NewNote()
        {
            InitializeComponent();
            note = new Note();
        }
        public NewNote(NoteService service,Note note)
        {
            InitializeComponent();
            this.note = note;
            this.service = service;
            txtbox_NotePad.Text = note.message;
            note_title.Text = note.title;
        }

        private void btn_SaveToCalendar_Click(object sender, EventArgs e)
        {
            //set the note's text
            note.set_message(txtbox_NotePad.Text);
            note.set_title(note_title.Text);
            //save the notes
            service.add_note(note);
            service.save_notes();

        }

        private void NewNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainNotePage notes = new MainNotePage(service);
            notes.Show();
        }

        private void btn_Trash_Click(object sender, EventArgs e)
        {
            service.remove_note(this.note);
            service.save_notes();
            this.Close();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
