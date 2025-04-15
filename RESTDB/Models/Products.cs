using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RESTDB.Models;

public class Products
{
	[Key]
	public int? Id { get; set; }

	// The category of the product (e.g., casket, jewelry)
	public string? Category { get; set; }

	// The specific item or product being purchased
	public string? Item { get; set; }

	// The tax rate applied to the service
	[Precision(18, 2)]
	public decimal? Tax { get; set; }

	// The price of the service or item
	[Precision(18, 2)]
	public decimal? Price { get; set; }
}
