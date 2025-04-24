using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Deceased
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)] // this disables auto-increment
	public string? ServiceID { get; set; }

	public string? Director { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? MiddleName { get; set; }
	public string? Title { get; set; }
	public string? Suffix { get; set; }
	public string? Need { get; set; }
	public string? Status { get; set; }
	public string? StreetAddress { get; set; }
	public string? City { get; set; }
	public string? State { get; set; }
	public string? ZipCode { get; set; }
	public string? ContractBalance { get; set; }
	public DateTime? DoD { get; set; }
	public DateTime? TimeOfDeath { get; set; }
	public string? SSN { get; set; }
	public string? Gender { get; set; }
	public string? MaidenName { get; set; }
	public string? Alias { get; set; }
	public string? Vet { get; set; }
	public string? War { get; set; }
	public string? InformantName { get; set; }
	public string? IStreetAddress { get; set; }
	public string? ICity { get; set; }
	public string? IState { get; set; }
	public string? IZipCode { get; set; }
	public string? IPhoneNumber { get; set; }
	public string? InformantEmail { get; set; }
	public DateTime? InfoNotified { get; set; }
	public string? Notes { get; set; }
	public byte[]? Image { get; set; }
	public string? InformantRelation { get; set; }
	public DateTime? DoB { get; set; }
	public string? Age { get; set; }
	public string? BCity { get; set; }
	public string? BZip { get; set; }
	public string? BCounty { get; set; }
	public string? BState { get; set; }
	public string? BCountry { get; set; }
	public string? MStatus { get; set; }
	public DateTime? MDate { get; set; }
	public string? MPlace { get; set; }
	public string? Church { get; set; }
	public string? RPreference { get; set; }
	public string? Clergy { get; set; }
	public string? HighSchool { get; set; }
	public string? HYoE { get; set; }
	public string? HEL { get; set; }
	public string? College { get; set; }
	public string? CYoE { get; set; }
	public string? CEL { get; set; }

	//Navigation Properties for Foreign Key
    public ICollection<Airline> Airline { get; set; } = new List<Airline>();
    public ICollection<Buyer> Buyer { get; set; } = new List<Buyer>();
    public ICollection<CashAdvance> CashAdvance { get; set; } = new List<CashAdvance>();
    public ICollection<CauseOfDeath> CauseOfDeath { get; set; }= new List<CauseOfDeath>();
    public ICollection<ContainerShipping> ContainerShipping { get; set; } = new List<ContainerShipping>();
    public ICollection<Embalmer> Embalmer { get; set; } = new List<Embalmer>();
    public ICollection<FlagApplication> FlagApplication { get; set; } = new List<FlagApplication>();
    public ICollection<Military> Military { get; set; } = new List<Military>();
    public ICollection<MilitaryStint> MilitaryStint { get; set; } = new List<MilitaryStint>();
    public ICollection<Monument> Monument { get; set; } = new List<Monument>();
    public ICollection<ObituaryData> ObituaryData { get; set; } = new List<ObituaryData>();
    public ICollection<PlaceOfDeath> PlaceOfDeath { get; set; } = new List<PlaceOfDeath>();
    public ICollection<Products> Products { get; set; } = new List<Products>();
    public ICollection<ServiceContract> ServiceContract { get; set; } = new List<ServiceContract>();
    public ICollection<Services> Services { get; set; } = new List<Services>();
    public ICollection<Survivors> Survivors { get; set; } = new List<Survivors>();
    public ICollection<WarsServed> WarsServed { get; set; } = new List<WarsServed>();
}
