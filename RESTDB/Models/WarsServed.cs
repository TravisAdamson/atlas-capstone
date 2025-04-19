using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class WarsServed
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? WarName { get; set; }
	public string? Description { get; set; }
	public string? WarMilitaryId { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
