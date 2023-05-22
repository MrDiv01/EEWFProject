﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Domain.Entities
{
    public class Support:Entity
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(30)]
        public string Mail { get; set; }
        [MaxLength(300)]
        public string Commend { get; set; } 
    }
}