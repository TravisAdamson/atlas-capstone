using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Military
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? Branch { get; set; }
	public string? Rank { get; set; }
	public string? ServiceNumber { get; set; }
	public DateTime? StartDate { get; set; }
	public DateTime? EndDate { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
