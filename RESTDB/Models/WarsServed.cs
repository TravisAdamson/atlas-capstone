using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class WarsServed
{
	[Key]
	public int ClientID { get; set; }

	public string? WarName { get; set; } // Example: "World War II", "Vietnam War", etc.
	public string? Description { get; set; } // Description of the war or specific involvement
	public string? WarMilitaryId { get; set; } // Needs to be limited to numbers possibly
	public Military? Military { get; set; } // Navigation property to the Military class
}
