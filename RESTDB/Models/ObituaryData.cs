using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class ObituaryData
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? DistributionFormat { get; set; }
	public string? Media { get; set; }
	public DateTime? DateSent { get; set; }
	public bool Primary { get; set; }
	public bool IncludePrimaryPhoto { get; set; }
	public bool ShowSurvivorAddresses { get; set; }
	public bool ShowSurvivorRelationships { get; set; }
	public string? RelationshipCount { get; set; }
	public string? WordCount { get; set; }
	public string? ObitNotes { get; set; }
	public string? LastPreneedId { get; set; }
	public string? LastAtneedId { get; set; }
	public string? Obituary { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
