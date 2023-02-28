using BookStore.BL.Interfaces;
using BookStore.Models.Base;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _authorService;

        public AuthorController(
            ILogger<AuthorController> logger,
            IAuthorService authorService)
        {
            _logger = logger;
            _authorService = authorService;
        }



        [HttpGet("GetAllAuthors")]
        public IEnumberable<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        [HttpGet("GetById")]
        public Author GetById(int d)
        {
            return _authorRepository.GetById(id);
        }

        [HttpPost("Add")]
        public void Add(FromBody, Author author)
        {
            _authorService.Add(author);
        }
    }
}