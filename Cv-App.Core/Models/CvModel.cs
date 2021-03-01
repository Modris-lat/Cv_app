using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cv_App.Core.Models
{
    public class CvModel: Entity
    {
        [DisplayName("CV Title")]
        public string CvTitle { get; set; }
        [DisplayName("Personal Data")]
        public virtual PersonalData PersonalData { get; set; }
        [DisplayName("Education")]
        public virtual List<Education> Educations { get; set; }
        [DisplayName("Work Experience")]
        public virtual List<WorkExperience> WorkExperiences { get; set; }
        [DisplayName("Additional Information")]
        public virtual List<Property> Properties { get; set; }
    }
}
