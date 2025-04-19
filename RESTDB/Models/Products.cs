using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Products
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? Category { get; set; }
	public string? Item { get; set; }

	[Precision(18, 2)]
	public decimal? Tax { get; set; }

	[Precision(18, 2)]
	public decimal? Price { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
