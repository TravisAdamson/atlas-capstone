using System.ComponentModel.DataAnnotations;

public class Buyer
{
    [Key]
    public int? Id { get; set; }
    
    // The date the buyer made the purchase or signed the contract
    public DateTime? Date { get; set; }
    
    // The sales package that the buyer purchased
    public string? SalesPackage { get; set; }
    
    // The name of the estate owner
    public string? EstateOwner { get; set; }
    
    // The balance due for the purchase
    public decimal? Balance { get; set; }
    
    // Any distributed charges related to the sale
    public decimal? DistributedCharges { get; set; }
}
