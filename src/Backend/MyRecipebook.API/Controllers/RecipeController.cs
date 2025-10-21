using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register()
        {
            return Created();
        }   
    }
}
