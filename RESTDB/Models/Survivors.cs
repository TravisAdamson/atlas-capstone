using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Survivors
{
	[Key]
<<<<<<< HEAD
	public int ClientID { get; set; }
	public string? SurvivorRelation { get; set; } // The type of survivor (e.g., spouse, child, grandchild)
	public string? Name { get; set; } // The name of the survivor
	public string? Address { get; set; } // The address of the survivor
	public string? GreatGrandChildrenCount { get; set; } // The number of great-grandchildren the Deceased had (limited to number)
	public string? GreatGreatGrandChildrenCount { get; set; } // The number of great-great-grandchildren the Deceased had (limited to number)
	public string? GreatGreatGreatGrandChildrenCount { get; set; } // The number of great-great-great-grandchildren the Deceased had (limited to number)
	public string? ChildrenCount { get; set; } // The number of children the Deceased had (limited to number)
	public string? GrandChildrenCount { get; set; } // The number of grandchildren the survivor has (limited to number)
	public string? PhoneNumber { get; set; } // The phone number of the survivor
	public string? Relationship { get; set; } // The relationship of the survivor to the deceased (e.g., son, daughter)
	public bool IsLiving { get; set; } // Whether the survivor is still living
=======
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? SurvivorRelation { get; set; }
	public string? Name { get; set; }
	public string? Address { get; set; }
	public string? GreatGrandChildrenCount { get; set; }
	public string? GreatGreatGrandChildrenCount { get; set; }
	public string? GreatGreatGreatGrandChildrenCount { get; set; }
	public string? ChildrenCount { get; set; }
	public string? GrandChildrenCount { get; set; }
	public string? PhoneNumber { get; set; }
	public string? Relationship { get; set; }
	public bool IsLiving { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
}
