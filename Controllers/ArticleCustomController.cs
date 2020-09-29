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
    public class ArticleCustomController : Controller
    {

        private readonly ArticleCustomService _articleService;
        public ArticleCustomController(ArticleCustomService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var articles = await _articleService.GetTopTakeArticles(2);
            return Ok(articles);
        }
    }
}
