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
        public virtual User CreatedBy { get; set; } = new User();
        public User UpdatedBy { get; set; } = new User();
        public DateTime? UpdatedAt { get; set; }
        public User DeletedBy { get; set; } = new User();
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
