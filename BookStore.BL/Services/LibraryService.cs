using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.DL.Repositories.InMemoryRepositories;
using BookStore.Models.Models;
using BookStore.Models.Response;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class LibraryService : ILibraryService
    {

        private readonly IBookRepository _bookRepository;
        private readonly IAuthorService _authorRepositroy;

        public LibraryService(IAuthorService authorRepository, IBookRepository bookRepository)
        {
            _authorRepositroy = authorRepository;
            _bookRepository = bookRepository;
        }


        public GetAllBooksByAuthorResponse GetAllBooksByAuthorId(int authorId)
        {
            return new GetAllBooksByAuthorResponse()
            {
                Author = _authorRepositroy.GetById(authorId),
                Books = _bookRepository.GetAllByAuthorId(authorId)

            };
        }
    }


}
