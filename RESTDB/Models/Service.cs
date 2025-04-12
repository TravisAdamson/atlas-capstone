using System.ComponentModel.DataAnnotations;

public class Service
{
    [Key]
    public int? Id { get; set; }
    
    // The category of the service (e.g., embalming, casket purchase)
    public string? Category { get; set; }
    
    // The specific item or service being provided
    public string? Item { get; set; }
    
    // The tax rate applied to the service
    public decimal? Tax { get; set; }
    
    // The price of the service or item
    public decimal? Price { get; set; }
}
