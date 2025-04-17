using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class Buyer
{
	[Key]

	public int ClientID { get; set; }

	// The name of the individual involved in the sales contract
	public string? Name { get; set; }

	// The address of the person involved in the contract
	public string? Address { get; set; }

	// The phone number of the person involved in the contract
	public string? PhoneNumber { get; set; }

	// The relationship of the buyer to the deceased (e.g., spouse, child)
	public string? Relationship { get; set; }

	// Whether the buyer is the primary buyer
	public bool IsPrimaryBuyer { get; set; }

	// Whether a bill needs to be sent to the buyer
	public bool SendBill { get; set; }
}
