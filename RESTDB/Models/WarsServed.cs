// Models/WarsServed.cs
using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class WarsServed
{
	[Key]
	public int? Id { get; set; }
	public string? WarName { get; set; } // Example: "World War II", "Vietnam War", etc.
	public string? Description { get; set; } // Description of the war or specific involvement

	// Needs to be limited to numbers possibly
	public string? WarMilitaryId { get; set; }
	public Military? Military { get; set; } // Navigation property to the Military class
}
