using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BLL.DTOs
{
    public class ProjectDTO
    {
        public int PId { get; set; }
        public string Name { get; set; }
        public int MId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}
