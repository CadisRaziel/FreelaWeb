using FreelaWeb.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreelaWeb.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        //Para listar um usuário
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //Para criar um novo usuário
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUser)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1}, createUser);
        }

        //Para verificar a ultima vez qeu ele logou
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel loginModel)
        {
            return NoContent();
        }

    }
}
