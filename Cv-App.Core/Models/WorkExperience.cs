using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cv_App.Core.Models
{
    public class WorkExperience: Entity
    {
        public int CvModelId { get; set; }
        [Required]
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        public string Company { get; set; }
        [DisplayName("Start Date")]
        public string StartDate { get; set; }
        [DisplayName("End Date")]
        public string EndDate { get; set; }
        [DisplayName("Job Description")]
        public string JobDescription { get; set; }
    }
}
