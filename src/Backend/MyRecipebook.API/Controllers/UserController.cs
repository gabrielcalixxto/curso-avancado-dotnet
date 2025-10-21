using Microsoft.AspNetCore.Mvc;
using MyRecipebook.Communication.Requests;

namespace MyApp.Namespace
{
    [Route("/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created    )]
        public IActionResult Register(RequestRegisterUserJson request)
        {
            return Created();
        }   
    }
}
