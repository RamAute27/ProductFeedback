using System.ComponentModel.DataAnnotations;

namespace ProductFeedbackApp.API.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Message { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }
    }
}
