using EEWF.Application.Interfaces;
using EEWF.Domain.DTOs;
using EEWF.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Infrastructure.Services
{
	public class CaruselService : ICaruselService
	{
		private readonly ApplicationDbContext _context;
        public CaruselService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<CaruselDto> GetCarusel()
		{
		   var carusel = _context.Carusels.Select(c=>new CaruselDto
		   {
			   Header = c.Header,
			   Title = c.Title,
			   Image = c.Image,
			   Url = c.Url,
		   }).ToList();
			return carusel;
		}
	}
}
