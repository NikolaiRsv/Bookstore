using BookStore.BL.Interfaces;
using BookStore.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace BookStore.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet("getAllBooksByAuthor")]  
        public GetAllBooksByAuthorResponse
          GetAllBooksByAuthor(int authorId)
        {
            return _libraryService.GetAllBooksByAuthorId(authorId);

        }
    }
}
