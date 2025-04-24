using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Monument
{
	[Key]
<<<<<<< HEAD
	public int ClientID { get; set; }
=======
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
	public string? MonumentType { get; set; }
	public string? Material { get; set; }
	public string? Engraving { get; set; }
	public DateTime? CreatedAt { get; set; } = DateTime.Now;

<<<<<<< HEAD
	// Constructor
	public Monument() { }
	public Monument(string monumentType, string material, string engraving)
	{
		MonumentType = monumentType;
		Material = material;
		Engraving = engraving;
	}
=======
	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
}
