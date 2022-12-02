using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularCRUD_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetPlayers()
        {
            return new List<Player>
            {
                new Player
                {
                    username = "rizkymaulana",
                    firstName = "Rizky",
                    lastName = "Maulana"
                }
            };
        }
    }
}
