using System.ComponentModel.DataAnnotations;

public class Obituary
{
    [Key]
    public int? Id { get; set; }
    
    // The format of the obituary distribution (e.g., print, online)
    public string? DistributionFormat { get; set; }
    
    // The type of media used for obituary distribution (e.g., newspaper, website)
    public string? Media { get; set; }
    
    // The date the obituary was sent out
    public DateTime? DateSent { get; set; }
    
    // Whether the obituary is a primary obituary (e.g., featured)
    public bool? Primary { get; set; }
    
    // Whether the primary photo is included with the obituary (e.g., in email or NOA)
    public bool? IncludePrimaryPhoto { get; set; }
    
    // Whether survivor addresses are displayed in the obituary
    public bool? ShowSurvivorAddresses { get; set; }
    
    // Whether relationships of the survivors are shown
    public bool? ShowSurvivorRelationships { get; set; }
    
    // The total number of relationships to be displayed in the obituary
    public int? RelationshipCount { get; set; }
    
    // The word count of the obituary text
    public int? WordCount { get; set; }
    
    // Any additional notes related to the obituary
    public string? ObitNotes { get; set; }
    
    // The ID of the last preneed transaction associated with this obituary
    public int? LastPreneedId { get; set; }
    
    // The ID of the last atneed transaction associated with this obituary
    public int? LastAtneedId { get; set; }
}
