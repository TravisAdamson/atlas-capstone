using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class Embalmer
{
	[Key]
	public int ClientID { get; set; }
	public bool PermissionToEmbalm { get; set; } // Whether permission has been given for embalming
	public bool Embalmed { get; set; } // Whether the embalming has been performed
	public DateTime? EmbalmedDate { get; set; } // The date when embalming was performed
	public DateTime? EmbalmedTime { get; set; } // The time when embalming was performed
	public string? EmbalmedBy { get; set; } // The name of the embalmer
	public string? EmbalmingAuthorizor { get; set; } // The person who authorized the embalming
}
