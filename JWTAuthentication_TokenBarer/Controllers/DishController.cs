using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class DishController : ControllerBase
    {


        private readonly List<Dish> Dishes = new List<Dish>()
        {
            new Dish { id = 01, Name = "paneer_tikka", category = "southindian", price= 2500 },
            new Dish { id = 02, Name = "chicken_65", category = "indian", price= 1500 },
            new Dish { id = 03, Name = "pizza", category = "italian", price= 2000 },
            new Dish { id = 04, Name = "burger", category = "american", price= 3000 }


        };

        private readonly ILogger<DishController> _logger;
        public DishController(ILogger<DishController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<Dish> Get()
        {
            return Dishes;
        }
        [HttpGet("{id:int}")]
        public Dish GetOne(int id)
        {
            return Dishes.SingleOrDefault(x => x.id == id);
        }



    }
}

