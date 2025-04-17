using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class MilitaryStint
{
	[Key]

	public int ClientID { get; set; }
	public string? Description { get; set; } // Example: "Deployed in Afghanistan"
	public DateTime? StartDate { get; set; }
	public DateTime? EndDate { get; set; }

	// Needs to be limited to a number possibly
	public string? StintMilitaryId { get; set; }
	public Military? Military { get; set; } // Navigation property to the Military class
}
