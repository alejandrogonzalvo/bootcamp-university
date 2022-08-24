using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public enum Level
    {
        Basic = 1,
        Intermediate = 2,
        Advanced = 3
    }

    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual string CreatedBy { get; set; } = String.Empty;
        public string UpdatedBy { get; set; } = String.Empty;
        public DateTime? UpdatedAt { get; set; }
        public string DeletedBy { get; set; } = String.Empty;
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
