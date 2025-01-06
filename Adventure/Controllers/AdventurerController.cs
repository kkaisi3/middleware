using Adventure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Adventure.Controllers
{
        [ApiController]
        [Route("/[controller]")]
    public class AdventurerController : ControllerBase
    {
        private IAdventurerService AdventurerService;

        public AdventurerController(IAdventurerService adventurerService)
        {
            AdventurerService = adventurerService;
        }

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    //Get List from Services
        //    return Ok(ReadAdventurers());
        //}

        [HttpGet]
        public IActionResult ReadAdventurers()
        {
            return Ok(AdventurerService.ReadAdventurers());
            
        }
    }
}
