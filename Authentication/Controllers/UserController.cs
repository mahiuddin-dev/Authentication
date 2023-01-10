using Authentication.Interfaces.Manager;
using Authentication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult GetAlluser()
        {
            try
            {
                var users = _userManager.GetAll();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // get single user
        [HttpGet("{id}")]
        public IActionResult GetUser(int id) 
        {
            try
            {
                var user = _userManager.GetById(id);
                if(user == null)
                {
                    return NotFound("User not found");
                }
                return Ok(user);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // user create method
        [HttpPost]
        public IActionResult Create(UserAuthentication user)
        {
            try
            {
                bool isSaved = _userManager.Add(user);
                if (isSaved)
                {
                    return Ok(user);
                }
                return BadRequest("Something Wrong");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
