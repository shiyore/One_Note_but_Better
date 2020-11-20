using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
        public NewNote()
        {
            InitializeComponent();
            note = new Note();
        }
        public NewNote(Note note)
        {
            InitializeComponent();
            this.note = note;
        }

        private void btn_SaveToCalendar_Click(object sender, EventArgs e)
        {
            //note = new Note();
            note.set_message(txtbox_NotePad.Text);
            string jsonFile = JsonConvert.SerializeObject(note);

            File.WriteAllText("notes.json", jsonFile);
            Console.WriteLine(JsonConvert.DeserializeObject<Note>(File.ReadAllText("notes.json")).message);

        }

        private void NewNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            string jsonFile = File.ReadAllText("notes.json");

            JObject parsed = JObject.Parse(jsonFile);

            foreach (var pair in parsed)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}
