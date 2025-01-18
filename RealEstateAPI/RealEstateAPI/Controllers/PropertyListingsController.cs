using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateAPI.Models;

namespace RealEstateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyListingsController : ControllerBase
    {
        private readonly RealEstateContext _context;    
        public PropertyListingsController (RealEstateContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<PropertyListing>> Get ()
        {
            var result = await _context.PropertyListings.ToListAsync();
            return result;
        }
    }
}
