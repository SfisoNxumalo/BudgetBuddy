using System.ComponentModel.DataAnnotations;

namespace BudgetBuddyApp.Server.Entities
{
    public class CategoryEntity : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        public Guid UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
