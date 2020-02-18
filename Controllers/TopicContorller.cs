using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi_Intro.Controllers
{
    [ApiController]
    [Route("topic")]
    public class TopicController : ControllerBase
    {
        private static List<IdTopic> Topic = new List<IdTopic>()
        {
            new IdTopic(){Id=1, Content="qwerty", Title= "Huruf", MemberId= 2},
            new IdTopic(){Id=2, Content="qwerty", Title= "Huruf", MemberId= 2},
            new IdTopic(){Id=3, Content="qwerty", Title= "Huruf", MemberId= 2},
            new IdTopic(){Id=4, Content="qwerty", Title= "Huruf", MemberId= 2},
            new IdTopic(){Id=5, Content="qwerty", Title= "Huruf", MemberId= 2},
        };

        private readonly ILogger<TopicController> _logger;

        public TopicController(ILogger<TopicController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { status="success", message="success get Data", data = Topic});
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(Topic.Find( e => e.Id == id));
        }

        [HttpPost]
        public IActionResult TopicAdd(IdTopic top)
        {
            var addTop = new IdTopic(){Id=top.Id, Content = top.Content, Title = top.Title, MemberId = top.MemberId};
            Topic.Add(addTop);
            return Ok(new { status = "success", message = "success add Data", data = Topic});
        }
    }
}
