using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Survivors
{
	[Key]
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
}
