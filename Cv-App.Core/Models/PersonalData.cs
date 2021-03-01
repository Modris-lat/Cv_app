using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Cv_App.Core.Models
{
    public class PersonalData: Entity
    {
        public int CvModelId { get; set; }
        public string Name { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
