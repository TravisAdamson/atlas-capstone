using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class PlaceOfDeath
{
    [Key]
    public int? Id { get; set; }

    // The name of the facility or place where death occurred
    public string? Name { get; set; }

    // The medical record number associated with the deceased
    public string? MedicalRecordNumber { get; set; }

    // The date of death field needs to be included

    // The time of death field needs to be included

    // The street address of the place of death
    public string? StreetAddress { get; set; }

    // The apartment number, if applicable, at the place of death
    public string? AptNumber { get; set; }

    // The type of Facility (e.g., hospital, hospice)
    public string? TypeOfFacility { get; set; }

    // The name of the person who took the call related to the death
    public string? CallTakenBy { get; set; }

    // The zip code of the place of death
    public string? ZipCode { get; set; }

    // The type of locality (e.g., urban, rural)
    public string? LocalityType { get; set; }

    // The township of the place of death
    public string? Township { get; set; }

    // The locality or area of the place of death
    public string? Locality { get; set; }

    // The state of the place of death
    public string? State { get; set; }

    // The county of the place of death
    public string? County { get; set; }

    // The country of the place of death
    public string? Country { get; set; }

    // Whether the place of death is within city limits
    public bool InCityLimits { get; set; }

    // The date the director was notified about the death
    public DateTime? DirectorNotifyDate { get; set; }

    // The time the director was notified about the death
    public DateTime? DirectorNotifedTime { get; set; }

    // The date the deceased was admitted to the place of death
    public DateTime? AdmissionDate { get; set; }

    // The time when the body was released
    public DateTime? BodyReleaseTime { get; set; }
}
