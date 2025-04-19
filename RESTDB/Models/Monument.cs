using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Monument
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? MonumentType { get; set; }
	public string? Material { get; set; }
	public string? Engraving { get; set; }
	public DateTime? CreatedAt { get; set; } = DateTime.Now;

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
