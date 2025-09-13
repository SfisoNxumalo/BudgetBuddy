using System.ComponentModel.DataAnnotations;

namespace BudgetBuddyApp.Server.Entities
{
    public class BaseEntity
    {

        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }



    }
}
