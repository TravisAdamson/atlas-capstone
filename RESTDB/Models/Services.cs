using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RESTDB.Models;

public class Services
{
	[Key]
	public int ClientID { get; set; }
	public string? Category { get; set; } // The category of the service (e.g., embalming, casket purchase)
	public string? Item { get; set; } // The specific item or service being provided

	[Precision(18, 2)] // The tax rate applied to the service
	public decimal? Tax { get; set; }

	[Precision(18, 2)] // The price of the service or item
	public decimal? Price { get; set; }
}
