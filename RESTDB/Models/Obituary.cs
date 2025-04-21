using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class ObituaryData
{
	[Key]
	public int ClientID { get; set; }
	public string? DistributionFormat { get; set; } // The format of the obituary distribution (e.g., print, online)
	public string? Media { get; set; } // The type of media used for obituary distribution (e.g., newspaper, website)
	public DateTime? DateSent { get; set; } // The date the obituary was sent out
	public bool Primary { get; set; } // Whether the obituary is a primary obituary (e.g., featured)
	public bool IncludePrimaryPhoto { get; set; } // Whether the primary photo is included with the obituary (e.g., in email or NOA)
	public bool ShowSurvivorAddresses { get; set; } // Whether survivor addresses are displayed in the obituary
	public bool ShowSurvivorRelationships { get; set; } // Whether relationships of the survivors are shown
	public string? RelationshipCount { get; set; } // The total number of relationships to be displayed in the obituary (limited to numbers)
	public string? WordCount { get; set; } // The word count of the obituary text (limited to numbers)
	public string? ObitNotes { get; set; } // Any additional notes related to the obituary
	public string? LastPreneedId { get; set; } // The ID of the last preneed transaction associated with this obituary
	public string? LastAtneedId { get; set; } // The ID of the last atneed transaction associated with this obituary
	public string? Obituary { get; set; }
}
