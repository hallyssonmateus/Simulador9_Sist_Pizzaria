using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_Pizzaria.Infra;
using Sistema_Pizzaria.Models;

namespace Sistema_Pizzaria.controller
{
    [Route("api/pizzas")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        //Injeção de dependencia - banco de dados
        private readonly PizzariaContext _context;
        //Contrutor da classe
        public PizzasController(PizzariaContext context)
        {
            _context = context;
        }

        // Endpoint para criar uma pizza
        [HttpPost]
        public ActionResult Add([FromBody] Pizza pizza)
        {
            if (pizza == null)
            {
                return BadRequest("Os dados da pizza são obrigatórios.");
            }
            _context.Pizzas.Add(pizza);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetPizza), new { id = pizza.Id }, pizza);
        }

        // Endpoint para atualizar uma pizza
        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Pizza pizza)
        {
            if (id != pizza.Id)
            {
                return BadRequest();
            }
            _context.Entry(pizza).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        //Retornar todas as pizzas
        [HttpGet]
        public ActionResult<IEnumerable<Pizza>> GetPizzas()
        {
            return _context.Pizzas.ToList();
        }

        // Endpoint para buscar uma pizza especifica pelo ID
        [HttpGet("{id}")]
        public ActionResult<Pizza> GetPizza(int id)
        {
            var pizza = _context.Pizzas.Find(id);
            if (pizza == null) return NotFound();
            return pizza;
        }

        //Endpoint para deletar uma pizza
        [HttpDelete("{id}")]
        public ActionResult DeletePizza(int id)
        {
            var pizza = _context.Pizzas.Find(id);
            if (pizza == null) return NotFound();
            _context.Pizzas.Remove(pizza);
            _context.SaveChanges();
            return NoContent();

        }
    }
}
