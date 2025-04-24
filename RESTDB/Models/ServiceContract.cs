using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class ServiceContract
{
	[Key]
<<<<<<< HEAD
	public int ClientID { get; set; }
	public DateTime? ContractDate { get; set; } // The date the buyer made the purchase or signed the contract
	public string? SalesPackage { get; set; } // The sales package that the buyer purchased
	public string? EstateOwner { get; set; } // The name of the estate owner

	[Precision(18, 2)] // The balance due for the purchase
	public decimal? Balance { get; set; }

	[Precision(18, 2)] // Any distributed charges related to the sale
=======
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public DateTime? ContractDate { get; set; }
	public string? SalesPackage { get; set; }
	public string? EstateOwner { get; set; }

	[Precision(18, 2)]
	public decimal? Balance { get; set; }

	[Precision(18, 2)]
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
	public decimal? DistributedCharges { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
