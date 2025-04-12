using System.ComponentModel.DataAnnotations;

public class Survivors
{
    [Key]
    public int? Id { get; set; }

    // The type of survivor (e.g., spouse, child, grandchild)
    public string? SurvivorRelation { get; set; }

    // The name of the survivor
    public string? Name { get; set; }

    // The address of the survivor
    public string? Address { get; set; }

    // The number of great-grandchildren the Deceased had (limited to number)
    public string? GreatGrandChildrenCount { get; set; }

    // The number of great-great-grandchildren the Deceased had (limited to number)
    public string? GreatGreatGrandChildrenCount { get; set; }

    // The number of great-great-great-grandchildren the Deceased had (limited to number)
    public string? GreatGreatGreatGrandChildrenCount { get; set; }

    // The number of children the Deceased had (limited to number)
    public string? ChildrenCount { get; set; }

    // The number of grandchildren the survivor has (limited to number)
    public string? GrandChildrenCount { get; set; }

    // The phone number of the survivor
    public string? PhoneNumber { get; set; }

    // The relationship of the survivor to the deceased (e.g., son, daughter)
    public string? Relationship { get; set; }

    // Whether the survivor is still living
    public bool? IsLiving { get; set; }
}
