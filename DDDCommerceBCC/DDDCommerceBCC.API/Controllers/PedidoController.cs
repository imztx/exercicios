using DDDCommerceBCC.Domain;
using DDDCommerceBCC.Infra;
using DDDCommerceBCC.Infra.Interfaces;
using DDDCommerceBCC.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DDDCommerceBCC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _context;

        public PedidoController(IPedidoRepository context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<Pedido> PostPedido(Pedido pedido)
        {
            _context.AddPedido(pedido);
            return CreatedAtAction("GetPedido", new { id = pedido.Id }, pedido);
        }

        [HttpGet]
        public ActionResult<List<Pedido>> GetPedidos()
        {
            return _context.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Pedido> GetPedido(int id)
        {
            var pedido = _context.GetPedidoById(id);

            if (pedido == null)
            {
                return NotFound();
            }

            return pedido;
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePedido(int id)
        {
            if (_context.DeletePedido(id))
                return Ok("Pedido Deletado com sucesso");

            return NotFound("Id nao encontrado");
        }

        [HttpPut("{id}")]
        public IActionResult PutPedido(int id, Pedido pedido)
        {
            if (id != pedido.Id)
            {
                return BadRequest();
            }

            var result = _context.UpdatePedido(pedido);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }



    }
}
