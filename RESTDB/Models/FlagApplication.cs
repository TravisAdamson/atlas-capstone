using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class FlagApplication
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? ApplicantName { get; set; }
	public string? RelationshipToDeceased { get; set; }
	public string? FlagType { get; set; }
	public DateTime? ApplicationDate { get; set; } = DateTime.Now;

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
