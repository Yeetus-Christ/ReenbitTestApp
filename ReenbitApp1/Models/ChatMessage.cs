using System.ComponentModel.DataAnnotations;

namespace ReenbitApp1.Models
{
    public class ChatMessage
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Sentiment { get; set; }
    }
}
