using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        public DateTime? EnrollmentDate { get; set; }
        public int StudentCount { get; set; }
    }
}
