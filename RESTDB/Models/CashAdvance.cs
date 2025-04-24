using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class CashAdvance
{
	[Key]
	public int RecordID { get; set; }

<<<<<<< HEAD
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
=======
	public string? ServiceID { get; set; }
	public string? Description { get; set; }

	[Precision(18, 2)]
	public decimal? Tax { get; set; }
	public string? Quantity { get; set; }

	[Precision(18, 2)]
	public decimal? Price { get; set; }

	[Precision(18, 2)]
	public decimal? PriceExtended { get; set; }
	public string? LastPreneedId { get; set; }
	public string? LastAtneedId { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
}
