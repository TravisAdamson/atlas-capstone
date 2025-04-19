using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class ServiceContract
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public DateTime? ContractDate { get; set; }
	public string? SalesPackage { get; set; }
	public string? EstateOwner { get; set; }

	[Precision(18, 2)]
	public decimal? Balance { get; set; }

	[Precision(18, 2)]
	public decimal? DistributedCharges { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
