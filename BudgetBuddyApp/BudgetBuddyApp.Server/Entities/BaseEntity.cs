using System.ComponentModel.DataAnnotations;

namespace BudgetBuddyApp.Server.Entities
{
    public class BaseEntity
    {

        [Key]
        public Guid Id { get; set; }

        public DateTime cCreatedAt { get; set; }
        public DateTime pdatedAt { get; set; }

    }
}
