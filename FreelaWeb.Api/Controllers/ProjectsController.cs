using FreelaWeb.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FreelaWeb.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]    
    public class ProjectsController : ControllerBase
    {
        /*
         * Criado para demonstrar que podemos impedir de receber requisições em um periodo de tempo ao ser configurado no appsettings e no program.cs
        private readonly OpeningTimeOption _option;
        public ProjectsController(IOptions<OpeningTimeOption> option)
        {
            _option = option.Value;
        }
        */

        //Para listar os projetos
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        //Para buscar um projeto
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //Para criar um novo projeto
        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        //Para atualizar um novo projeto
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 250)
            {
                return BadRequest();
            }
            return NoContent();
        }

        //Para deletar
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        //Para criar um comentario
        [HttpPost("{id}/comments")]
        public IActionResult PostComment([FromBody] CreateCommentModel createComment, int id)
        {
            return NoContent();
        }

        //Para iniciar um projeto
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        //Para finalizar um projeto
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }

    }
}
