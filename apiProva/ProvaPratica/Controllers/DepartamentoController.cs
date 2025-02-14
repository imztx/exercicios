using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaPratica.Data;
using ProvaPratica.Entities;

namespace ProvaPratica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly DataContext departamentodataContext;
        public DepartamentoController(DataContext departamento_dataContext)
        {
            departamentodataContext = departamento_dataContext;
        }

        [HttpPost]
        public ActionResult<Departamento> Create([FromBody] Departamento departamento)
        {
            var funcionario = departamentodataContext.Funcionarios.FirstOrDefault(f => f.Id == departamento.FuncionarioID);
            if (funcionario == null)
            {
                return NotFound();
            }
            departamento.Funcionario = funcionario;

            departamentodataContext.Add(departamento);
            departamentodataContext.SaveChanges();
            return Ok("Funcionario adicionado com sucesso");
        }

        [HttpGet]
        public ActionResult<IEnumerable<Departamento>> GetAll()
        {
            var departamentos = departamentodataContext.Departamentos.Include(e => e.Funcionario).ToList();
            return Ok(departamentos);
        }

        
    }
}
