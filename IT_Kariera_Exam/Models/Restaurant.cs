using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Net.Sockets;

namespace IT_Kariera_Exam.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(64, ErrorMessage = "Name must be less than 65 characters")]
        public string Name { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Description must be less than 256 characters")]
        public string Description { get; set; }

        [Required]
        public string PhotoURL { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [DefaultValue(null)]
        public virtual ICollection<Review>? Reviews { get; set; }
    }
}
