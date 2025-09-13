using System.ComponentModel.DataAnnotations;

namespace BudgetBuddyApp.Server.DTOs
{
    //This DTO was created using ChatGPT
    public class AddCategoryDTO
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public Guid UserId { get; set; }
    }
}
