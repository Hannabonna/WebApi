using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi_Intro.Controllers
{
    [ApiController]
    [Route("member")]
    public class MemberController : ControllerBase
    {
        private static List<IdMember> Members = new List<IdMember>()
        {
            new IdMember(){Id=1, Username="qwerty", Password="mnbv12", Email="email@gmail.com", FullName="hahaha", Popularity="80"},
            new IdMember(){Id=2, Username="qwerty", Password="mnbv12", Email="email@gmail.com", FullName="hahaha", Popularity="80"},
            new IdMember(){Id=3, Username="qwerty", Password="mnbv12", Email="email@gmail.com", FullName="hahaha", Popularity="80"},
            new IdMember(){Id=4, Username="qwerty", Password="mnbv12", Email="email@gmail.com", FullName="hahaha", Popularity="80"},
            new IdMember(){Id=5, Username="qwerty", Password="mnbv12", Email="email@gmail.com", FullName="hahaha", Popularity="80"},
        };

        private readonly ILogger<MemberController> _logger;

        public MemberController(ILogger<MemberController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { status="success", message="success get Data", data = Members});
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(Members.Find( e => e.Id == id));
        }

        [HttpPost]
        public IActionResult MemberAdd(IdMember mem)
        {
            var addMember = new IdMember(){Id=mem.Id, Username = mem.Username, Password = mem.Password, Email = mem.Email, FullName = mem.FullName, Popularity = mem.Popularity};
            Members.Add(addMember);
            return Ok(new { status = "success", message = "success add Data", data = Members});
        }
    }
}
