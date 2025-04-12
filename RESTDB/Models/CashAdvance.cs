using System.ComponentModel.DataAnnotations;

public class CashAdvance
{
    [Key]
    public int? Id { get; set; }
    
    // A description of the cash advance
    public string? Description { get; set; }
    
    // The tax amount associated with the advance
    public decimal? Tax { get; set; }
    
    // The quantity of the items associated with the cash advance
    public int? Quantity { get; set; }
    
    // The price per item or service
    public decimal? Price { get; set; }
    
    // The total price calculated as Price * Quantity
    public decimal? PriceExtended { get; set; }
    
    // The ID of the last preneed transaction
    public int? LastPreneedId { get; set; }
    
    // The ID of the last atneed transaction
    public int? LastAtneedId { get; set; }
}
