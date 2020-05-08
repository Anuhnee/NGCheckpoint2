using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capstone.Data;
using capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace capstone.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ReviewController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Review> Get()
        {
            Review[] reviews = null;
            using (var context = new ApplicationDbContext())
            {
                reviews =  context.Reviews.ToArray();
            }
            return reviews;
            
        }
    }
}
