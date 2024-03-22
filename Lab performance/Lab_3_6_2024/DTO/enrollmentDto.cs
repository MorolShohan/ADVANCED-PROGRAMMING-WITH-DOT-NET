using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_3_6_2024.Dto
{
    public class enrollmentDto
    {
        public int EnrollmentId { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
    }
}