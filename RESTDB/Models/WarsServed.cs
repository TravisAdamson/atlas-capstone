using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class WarsServed
{
	[Key]
	public int RecordID { get; set; }

<<<<<<< HEAD
	public string? WarName { get; set; } // Example: "World War II", "Vietnam War", etc.
	public string? Description { get; set; } // Description of the war or specific involvement
	public string? WarMilitaryId { get; set; } // Needs to be limited to numbers possibly
	public Military? Military { get; set; } // Navigation property to the Military class
=======
	public string? ServiceID { get; set; }
	public string? WarName { get; set; }
	public string? Description { get; set; }
	public string? WarMilitaryId { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
}
