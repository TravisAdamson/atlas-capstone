using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Buyer
{
	[Key]
<<<<<<< HEAD
	public int ClientID { get; set; }
	public string? Name { get; set; } // The name of the individual involved in the sales contract
	public string? Address { get; set; } // The address of the person involved in the contract
	public string? PhoneNumber { get; set; } // The phone number of the person involved in the contract
	public string? Relationship { get; set; } // The relationship of the buyer to the deceased (e.g., spouse, child)
	public bool IsPrimaryBuyer { get; set; } // Whether the buyer is the primary buyer
	public bool SendBill { get; set; } // Whether a bill needs to be sent to the buyer
=======
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
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
}
