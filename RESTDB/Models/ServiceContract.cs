using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RESTDB.Models;

public class ServiceContract
{
	[Key]
	public int ClientID { get; set; }
	public DateTime? ContractDate { get; set; } // The date the buyer made the purchase or signed the contract
	public string? SalesPackage { get; set; } // The sales package that the buyer purchased
	public string? EstateOwner { get; set; } // The name of the estate owner

	[Precision(18, 2)] // The balance due for the purchase
	public decimal? Balance { get; set; }

	[Precision(18, 2)] // Any distributed charges related to the sale
	public decimal? DistributedCharges { get; set; }
}
