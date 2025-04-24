using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Embalmer
{
	[Key]
<<<<<<< HEAD
	public int ClientID { get; set; }
	public bool PermissionToEmbalm { get; set; } // Whether permission has been given for embalming
	public bool Embalmed { get; set; } // Whether the embalming has been performed
	public DateTime? EmbalmedDate { get; set; } // The date when embalming was performed
	public DateTime? EmbalmedTime { get; set; } // The time when embalming was performed
	public string? EmbalmedBy { get; set; } // The name of the embalmer
	public string? EmbalmingAuthorizor { get; set; } // The person who authorized the embalming
=======
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public bool PermissionToEmbalm { get; set; }
	public bool Embalmed { get; set; }
	public DateTime? EmbalmedDate { get; set; }
	public DateTime? EmbalmedTime { get; set; }
	public string? EmbalmedBy { get; set; }
	public string? EmbalmingAuthorizor { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
}
