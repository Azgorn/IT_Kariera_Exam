using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Xml.Linq;

namespace IT_Kariera_Exam.Models
{
    public class User : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DefaultValue(null)]
        public virtual ICollection<Review>? Reviews { get; set; }

    }
}
