using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnowledgeApi.Models;
using KnowledgeApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleCustomController : ControllerBase
    {

        private readonly ArticleCustomService _articleService;
        public ArticleCustomController(ArticleCustomService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Article>>> GetAll()
        {
            var students = await _articleService.GetTopTen(10);
            return Ok(students);
        }
    }
}
