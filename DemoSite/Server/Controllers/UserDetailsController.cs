using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SqlServer;

namespace DemoSite.Server.Controllers
{
    [ApiController]
    public class UserDetailsController : Controller
    {
        private DemoContext context { get; set; }
       public UserDetailsController(DemoContext _context)
        {
            context = _context;
        }
        [HttpGet]
        [Route("[controller]")]
        [Route("[controller]/{UserName}")]
        public User Get(string UserName)
        {
            return context.Users.FirstOrDefault();

        }
        [HttpGet]
        [Route("[controller]/[action]")]
        public IEnumerable<User> ListUsers()
        {
            return context.Users;
        }
    }
}
