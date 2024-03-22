using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_3_6_2024.Dto
{
    public class projectDto
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ExpectedDeadline { get; set; }
    }
}