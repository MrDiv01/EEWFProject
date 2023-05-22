using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Domain.Entities
{
    public class Teacher:Entity
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(150)]

        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile {  get; set; }
        public int CatagoryId { get; set; }
        public Catagory Catagory { get; set; }
    }
}
