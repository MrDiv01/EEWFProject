using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Domain.DTOs
{
	public class CaruselDto
	{
		public string Header { get; set; }
		public string Title { get; set; }
		public string Image { get; set; }
		public string Url { get; set; }
	}
}
