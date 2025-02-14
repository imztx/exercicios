using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvaPratica.Data;
using ProvaPratica.Entities;

namespace ProvaPratica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public FuncionarioController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public ActionResult<Funcionario> Create([FromBody] Funcionario funcionario)
        {
            _dataContext.Add(funcionario);
            _dataContext.SaveChanges();
            return Ok("Funcionario adicionado com sucesso");
        }

        [HttpGet]
        public ActionResult<Funcionario> Get()
        {
            var funcionarioencontrado = _dataContext.Funcionarios.ToList();
            if (funcionarioencontrado == null)
            {
                return NotFound();
            }
            return Ok(funcionarioencontrado);
        }

        [HttpGet("{id}")]
        public ActionResult<Funcionario> GetById(int id)
        {
            var funcionarioencontrado = _dataContext.Funcionarios.FirstOrDefault(x => x.Id == id);
            if (funcionarioencontrado == null)
            {
                return NotFound();
            }
            return Ok(funcionarioencontrado);
        }

        [HttpPut("{id}")]
        public ActionResult<Funcionario> Put(int id, Funcionario funcionario)
        {
            var funcionarioencontrado = _dataContext.Funcionarios.FirstOrDefault(x => x.Id == id);
            if (funcionarioencontrado == null)
            {
                return NotFound();
            }
            funcionarioencontrado.Name = funcionario.Name;
            funcionarioencontrado.Email = funcionario.Email;

            _dataContext.Update(funcionarioencontrado);
            _dataContext.SaveChanges();

            return Ok(funcionarioencontrado);
        }

        [HttpDelete("{id}")]
        public ActionResult<Funcionario> Delete(int id)
        {
            var funcionarioencontrado = _dataContext.Funcionarios.FirstOrDefault(x => x.Id == id);
            if (funcionarioencontrado == null)
            {
                return NotFound();
            }
            _dataContext.Remove(funcionarioencontrado);
            _dataContext.SaveChanges();
            return Ok(funcionarioencontrado);
        }
    }
}
