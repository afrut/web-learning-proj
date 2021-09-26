using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TourOfHeroes.Controllers
{
    [ApiController]
    [Route("/api/heroes")]
    public class HeroesController : ControllerBase
    {
        private readonly ILogger<HeroesController> _logger;

        public HeroesController(ILogger<HeroesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return new Hero[] {
                new Hero { Id = 11, Name = "Dr Nice" },
                new Hero { Id = 12, Name = "Narco" },
                new Hero { Id = 13, Name = "Bombasto" },
                new Hero { Id = 14, Name = "Celeritas" },
                new Hero { Id = 15, Name = "Magneta" },
                new Hero { Id = 16, Name = "RubberMan" },
                new Hero { Id = 17, Name = "Dynama" },
                new Hero { Id = 18, Name = "Dr IQ" },
                new Hero { Id = 19, Name = "Magma" },
                new Hero { Id = 20, Name = "Tornado" }
            };
        }
    }
}
