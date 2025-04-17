using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class Military
{
	[Key]

	public int ClientID { get; set; }
	public string? Branch { get; set; } // Example: Army, Navy, Air Force, etc.
	public string? Rank { get; set; }
	public string? ServiceNumber { get; set; }
	public DateTime? StartDate { get; set; }
	public DateTime? EndDate { get; set; }

	public ICollection<MilitaryStint>? MilitaryStint { get; set; } // Related to MilitaryStint class
	public ICollection<WarsServed>? WarsServed { get; set; } // Related to WarsServed class
}
