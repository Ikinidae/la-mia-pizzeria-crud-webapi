using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Controllers.API
{
    [Route("api/[controller]/[action]", Order = 1)]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        IDbPizzaRepository _pizzaRepository;

        public PizzaController(IDbPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public IActionResult Get()
        {
            List<Pizza> pizzas = _pizzaRepository.All();
            return Ok(pizzas);
        }

        public IActionResult Search(string? name)
        {

            List<Pizza> pizzas = _pizzaRepository.SearchByName(name);

            return Ok(pizzas);

        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            Pizza pizza = _pizzaRepository.GetById(id);

            return Ok(pizza);
        }
    }
}
