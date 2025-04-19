using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Embalmer
{
	[Key]
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
}
