using System;
using Enums;
namespace Models
{
    public class Serie : BaseEntity
    {
    	private Gender Gender { get; set; }
	private string Title { get; set; }
	private string Description { get; set; }
	private int Year { get; set; }
	private bool Deleted {get; set;}        
	public Serie(int id, Gender gender, string title, string description, int year)
	{
	    this.Id = id;
	    this.Gender = gender;
	    this.Title = title;
	    this.Description = description;
	    this.Year = year;
	    this.Deleted = false;
	}
	public override string ToString()
	{
	    // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
	    string retorno = "";
	    retorno += "Gender: " + this.Gender + Environment.NewLine;
	    retorno += "Title: " + this.Title + Environment.NewLine;
	    retorno += "Description: " + this.Description + Environment.NewLine;
	    retorno += "Start Year: " + this.Year + Environment.NewLine;
	    retorno += "Deleted: " + this.Deleted;
	    return retorno;
	}
	public int GetId()
	{
	    return this.Id;
	}
	public string GetTitle()
	{
	    return this.Title;
	}
	public bool GetDeleted()
	{
	    return this.Deleted;
	}
	public void SetDeleted()
	{
	    this.Deleted = true;
	}
        // public void Delete() {
        //     this.Deleted = true;
        // }
    }
}
