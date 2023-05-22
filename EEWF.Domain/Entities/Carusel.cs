using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Domain.Entities
{
	public class Carusel:Entity
	{
		[MaxLength(30)]
		public string Header { get; set; }
		[MaxLength(100)]
		public string Title { get; set; }
		public string Image { get; set; }
		[NotMapped]
		public IFormFile ImageFile { get; set; }
		public string Url { get; set; }
		public string UrlText { get; set; }

		//Test
    }
}
