using System;

public class NoteService
{
    public List notes;
	public NoteService()
	{
        notes = new ArrayList();
	}
    public NoteService(Arraylist notes)
    {
        this.notes = notes;
    }

    public void load_notes()
    {
        string jsonFile = File.ReadAllText("notes.json");
        notes = JsonConvert.DeserializeObject<List<Note>>(jsonFile);

    }

}
