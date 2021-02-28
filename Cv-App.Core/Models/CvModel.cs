using System.Collections.Generic;

namespace Cv_App.Core.Models
{
    public class CvModel: Entity
    {
        public string CvTitle { get; set; }
        public virtual List<Property> Properties { get; set; }
    }
}
