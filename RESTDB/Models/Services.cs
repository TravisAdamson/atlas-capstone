using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Services
{
	[Key]
<<<<<<< HEAD
	public int ClientID { get; set; }
	public string? Category { get; set; } // The category of the service (e.g., embalming, casket purchase)
	public string? Item { get; set; } // The specific item or service being provided

	[Precision(18, 2)] // The tax rate applied to the service
	public decimal? Tax { get; set; }

	[Precision(18, 2)] // The price of the service or item
=======
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? Category { get; set; }
	public string? Item { get; set; }

	[Precision(18, 2)]
	public decimal? Tax { get; set; }

	[Precision(18, 2)]
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
	public decimal? Price { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
