using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RESTDB.Models;

public class CashAdvance
{
    [Key]
    public int? Id { get; set; }

    // A description of the cash advance
    public string? Description { get; set; }

    // The tax amount associated with the advance
	[Precision(18, 2)]
    public decimal? Tax { get; set; }

    // The quantity of the items associated with the cash advance (limited to numbers)
    public string? Quantity { get; set; }

    // The price per item or service
	[Precision(18, 2)]
    public decimal? Price { get; set; }

    // The total price calculated as Price * Quantity
	[Precision(18, 2)]
    public decimal? PriceExtended { get; set; }

    // The ID of the last preneed transaction
    public string? LastPreneedId { get; set; }

    // The ID of the last atneed transaction
    public string? LastAtneedId { get; set; }
}
