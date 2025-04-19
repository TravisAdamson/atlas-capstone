using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class CashAdvance
{
	[Key]
	public int RecordID { get; set; }

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
}
