using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi_Intro.Controllers
{
    [ApiController]
    [Route("kategori")]
    public class CategoriesController : ControllerBase
    {
        private static List<Primary> Categori = new List<Primary>()
        {
            new Primary(){Id=1, Name="qwerty", Description="this is a qwerty"},
            new Primary(){Id=2, Name="qwerty", Description="this is a qwerty"},
            new Primary(){Id=3, Name="qwerty", Description="this is a qwerty"},
            new Primary(){Id=4, Name="qwerty", Description="this is a qwerty"},
            new Primary(){Id=5, Name="qwerty", Description="this is a qwerty"},
        };

        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ILogger<CategoriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { status="success", message="success get Data", data = Categori});
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(Categori.Find( e => e.Id == id));
        }

        [HttpPost]
        public IActionResult CategoriesAdd(Primary prim)
        {
            var addCate = new Primary(){Id=prim.Id, Name = prim.Name, Description = prim.Description};
            Categori.Add(addCate);
            return Ok(new { status = "success", message = "success add Data", data = Categori});
        }
    }
}
