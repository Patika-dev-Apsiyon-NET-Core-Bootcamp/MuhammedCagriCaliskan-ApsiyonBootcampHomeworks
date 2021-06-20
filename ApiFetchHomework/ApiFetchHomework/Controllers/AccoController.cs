using ApiWeb.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApiFetchHomework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccoController : ControllerBase
    {
        private readonly ModelContext _db;
        private readonly IUserService _userService;
        public AccoController(ModelContext db, IUserService UserService)
        {
            _db = db;
            _userService = UserService;
        }

        [HttpGet("Login")]
        public IActionResult Login(string email, string password)
        {
            User u = _db.Users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if(u != null)
            {
               return Ok();
            }
            
            return BadRequest();
        }
    }
}
