using System.ComponentModel.DataAnnotations;

namespace KanbanBoardDemo.ViewModels
{
    public class AddCard
    {
        public int Id { get; set; }

        [Required]
        public string Contents { get; set; }
    }
}
