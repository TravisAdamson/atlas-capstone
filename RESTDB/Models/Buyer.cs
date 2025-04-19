using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Buyer
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? Name { get; set; }
	public string? Address { get; set; }
	public string? PhoneNumber { get; set; }
	public string? Relationship { get; set; }
	public bool IsPrimaryBuyer { get; set; }
	public bool SendBill { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
