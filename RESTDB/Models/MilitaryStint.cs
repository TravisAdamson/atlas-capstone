using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class MilitaryStint
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? StintDescription { get; set; }
	public DateTime? StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public string? StintMilitaryId { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
