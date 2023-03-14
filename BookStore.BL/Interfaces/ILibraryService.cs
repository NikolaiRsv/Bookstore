using BookStore.Models.Models;
using BookStore.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{

    public interface ILibraryService
    {
        GetAllBooksByAuthorResponse
            GetAllBooksByAuthorId(int authorId);
    }
}

