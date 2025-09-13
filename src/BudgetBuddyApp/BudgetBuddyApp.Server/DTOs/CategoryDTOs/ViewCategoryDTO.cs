using BudgetBuddyApp.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace BudgetBuddyApp.Server.DTOs.CategoryDTOs
{
    public class ViewCategoryDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
