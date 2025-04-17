using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RESTDB.Models;

public class ServiceContract
{
	[Key]

	public int ClientID { get; set; }

	// The date the buyer made the purchase or signed the contract
	public DateTime? ContractDate { get; set; }

	// The sales package that the buyer purchased
	public string? SalesPackage { get; set; }

	// The name of the estate owner
	public string? EstateOwner { get; set; }

	// The balance due for the purchase
	[Precision(18, 2)]
	public decimal? Balance { get; set; }

	// Any distributed charges related to the sale
	[Precision(18, 2)]
	public decimal? DistributedCharges { get; set; }
}
