using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cv_App.Core.Models
{
    public class PersonalData: Entity
    {
        public int CvModelId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
