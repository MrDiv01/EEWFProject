﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Domain.Entities
{
    public class About : Entity
    {
        [MaxLength(50)]
        public string Header { get;set; }
        [MaxLength(500)]
        public string Title { get;set; }
        public string Image { get;set; }
        [NotMapped]
        public IFormFile ImageFile { get;set; }
    }
}
