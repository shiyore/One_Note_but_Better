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
        private List<String> sort_methods = new List<string>(){"None","Title","Date", "Date Created"};
        private List<Note> ordered_notes = new List<Note>();
        public MainNotePage(NoteService service)
        {
            InitializeComponent();
            this.service = service;
            notes_list.DataSource = service.notes   ;
            notes_list.DisplayMember = "title";
            sort_type.DataSource = sort_methods;
        }

        private void btn_NewNote_Click(object sender, EventArgs e)
        {
            Note new_note = new Note();
            NewNote note_page = new NewNote(service, new_note);
            note_page.Show();
            this.Close();
        }
        void notes_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.notes_list.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }
        }

        private void notes_list_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int index = this.notes_list.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                NewNote edit_note = new NewNote(service, ordered_notes[index]);
                edit_note.Show();
                this.Close();
            }
        }

        private void lbl_Sort_Click(object sender, EventArgs e)
        {
            List<Note> ordered_notes = this.service.notes.OrderBy(o => o.title).ToList();
            notes_list.DataSource = ordered_notes;
            notes_list.DisplayMember = "title";
        }

        private void sort_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Console.WriteLine(sort_type.Text);

            //Sorting the list based on sort method
            switch (sort_type.Text)
            {

                case "Title":
                    ordered_notes = this.service.notes.OrderBy(o => o.title).ToList();
                    break;
                case "Date":
                    ordered_notes = this.service.notes.OrderBy(o => o.date).ToList();
                    break;
                case "Date Created":
                    ordered_notes = this.service.notes.OrderBy(o => o.date_created).ToList();
                    break;
                default:
                    ordered_notes = service.notes;
                    break;
            }
            notes_list.DataSource = ordered_notes;
            notes_list.DisplayMember = "title";
        }
    }
}
