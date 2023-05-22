using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Domain.Entities
{
    public class CourseGategory:Entity
    {
        public string Icon { get; set; }
        [MaxLength(30)]
        public string IconName { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
