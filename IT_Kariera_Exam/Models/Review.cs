using System.ComponentModel.DataAnnotations;

namespace IT_Kariera_Exam.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public int EventId { get; set; }
        public User User { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
