using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        List<Entidades.Curso> Cursos = new List<Entidades.Curso>()
        {
            new Entidades.Curso(1, "Administracao", true),
            new Entidades.Curso(2, "Arquitetura" , true),
            new Entidades.Curso(3, "Medicina" , true),
            new Entidades.Curso(4, "Engenharia" , true),
            new Entidades.Curso(5, "psicologia" , true)

        };

        [HttpGet("cursos")]
        public ActionResult GetCursos()
        {
            return Ok(Cursos);
        }

        [HttpPost("AddCursos")]
        public ActionResult PostCursos(int ID, string Nome, bool Ativo)
        {
            Cursos.Add(new Entidades.Curso(ID, Nome, Ativo));
            return Ok(Cursos);
        }

        [HttpPut("AlteraCursos")]
        public ActionResult PutCursos(int ID, string Nome, bool Ativo)
        {
            foreach (var item in Cursos)
            {
                if (item.ID == ID)
                {
                    item.Nome = Nome;
                    item.Ativo = Ativo;
                    return Ok(Cursos);
                }
            }
            return BadRequest();

        }

        [HttpDelete("DeletaCursos")]
        public ActionResult DelCursos(int ID)
        {
            foreach (var item in Cursos)
            {
                if (item.ID == ID)
                {
                    Cursos.Remove(item);
                    return Ok();
                }
            }
            return NotFound();

        }


    }

}
