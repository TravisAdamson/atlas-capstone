using System;
using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Monument
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string MonumentType { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Material { get; set; }
        
        public string Engraving { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Constructor
        public Monument() { }

        public Monument(string monumentType, string material, string engraving)
        {
            MonumentType = monumentType;
            Material = material;
            Engraving = engraving;
        }
    }
}
