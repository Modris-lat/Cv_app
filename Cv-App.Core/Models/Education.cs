using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Cv_App.Core.Models
{
    public class Education: Entity
    {
        public int CvModelId { get; set; }
        public string Degree { get; set; }
        [Required]
        public string Specialization { get; set; }
        public string School { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
