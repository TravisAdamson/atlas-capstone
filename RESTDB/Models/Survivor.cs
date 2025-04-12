using System.ComponentModel.DataAnnotations;

public class Survivor
{
    [Key]
    public int? Id { get; set; }
    
    // The type of survivor (e.g., spouse, child, grandchild)
    public string? SurvivorType { get; set; }
    
    // The name of the survivor
    public string? Name { get; set; }
    
    // The address of the survivor
    public string? Address { get; set; }
    
    // The number of great-grandchildren the survivor has
    public int? GreatGrandChildrenCount { get; set; }
    
    // The number of great-great-grandchildren the survivor has
    public int? GreatGreatGrandChildrenCount { get; set; }
    
    // The number of great-great-great-grandchildren the survivor has
    public int? GreatGreatGreatGrandChildrenCount { get; set; }
    
    // The number of children the survivor has
    public int? ChildrenCount { get; set; }
    
    // The number of grandchildren the survivor has
    public int? GrandChildrenCount { get; set; }
    
    // The phone number of the survivor
    public string? PhoneNumber { get; set; }
    
    // The relationship of the survivor to the deceased (e.g., son, daughter)
    public string? Relationship { get; set; }
    
    // Whether the survivor is still living
    public bool? IsLiving { get; set; }
}
