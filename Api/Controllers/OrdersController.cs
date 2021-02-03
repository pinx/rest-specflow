using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scheduling.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Order
            {
                Id = index,
                StartAt = rng.Next(5),
                DueAt = 4 + rng.Next(5),
                StartLocation = rng.Next(10),
                Destination = rng.Next(10)
            });
        }
    }
}
