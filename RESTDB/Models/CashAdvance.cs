using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RESTDB.Models;

public class CashAdvance
{
	[Key]

	public int ClientID { get; set; }
	public string? Description { get; set; } // A description of the cash advance

	[Precision(18, 2)] // The tax amount associated with the advance
	public decimal? Tax { get; set; }
	public string? Quantity { get; set; } // The quantity of the items associated with the cash advance (limited to numbers)

	[Precision(18, 2)] // The price per item or service
	public decimal? Price { get; set; }

	[Precision(18, 2)] // The total price calculated as Price * Quantity
	public decimal? PriceExtended { get; set; }
	public string? LastPreneedId { get; set; } // The ID of the last preneed transaction
	public string? LastAtneedId { get; set; } // The ID of the last atneed transaction
}
