using System.ComponentModel.DataAnnotations;

namespace Cv_App.Core.Models
{
    public class Property: Entity
    {
        public int CvModelId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
