using System.ComponentModel.DataAnnotations;

namespace BudgetBuddyApp.Server.Entities
{
    public class UserEntity : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(200)]
        public string Email { get; set; }

        public ICollection<CategoryEntity> Categories { get; set; } = new List<CategoryEntity>();
    }
}
