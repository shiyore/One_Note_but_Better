using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class MainNotePage : Form
    {
        public MainNotePage()
        {
            InitializeComponent();
        }

        private void btn_NewNote_Click(object sender, EventArgs e)
        {
            Note new_note = new Note();
            NewNote note_page = new NewNote(new_note);
            
            note_page.Show();
            string jsonFile = JsonConvert.SerializeObject(new_note);

            JObject parsed = JObject.Parse(jsonFile);

            foreach (var pair in parsed)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}
