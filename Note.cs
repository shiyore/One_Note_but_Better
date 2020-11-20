using System;

public class Note
{
    //Every note should be able to store a title, date, message content, and date created
    private String title;
    private DateTime date;
    private DateTime date_created;
    private String message;


	public Note()
	{
        title = "Note Title";
        message = "";
        date = DateTime.Now;
        date_created = DateTime.Now;
	}
    public Note(String title, String message, DateTime date, DateTime date_created)
    {
        this.title = title;
        this.message = message;
        this.date = date;
        this.date_created;
    }

    public String get_title()
    {
        return this.title; 
    }
    public void set_title(String title)
    {
        this.title = title;
    }
    public String get_message()
    {
        return this.message;
    }
    public void set_message(String message)
    {
        this.message = message;
    }
    public DateTime get_date()
    {
        return this.date;
    }
    public void set_date(DateTime date)
    {
        this.date = date;
    }
    public DateTime get_date_created()
    {
        return this.date_created;
    }
    public void set_date_created(DateTime date_created)
    {
        this.date_created = date_created;
    }
}
