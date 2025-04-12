using System;
using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class FlagApplication
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string ApplicantName { get; set; }
        
        [Required]
        [StringLength(100)]
        public string RelationshipToDeceased { get; set; }
        
        [Required]
        [StringLength(100)]
        public string FlagType { get; set; }

        public DateTime ApplicationDate { get; set; } = DateTime.Now;

        // Constructor
        public FlagApplication() { }

        public FlagApplication(string applicantName, string relationshipToDeceased, string flagType)
        {
            ApplicantName = applicantName;
            RelationshipToDeceased = relationshipToDeceased;
            FlagType = flagType;
        }
    }
}
