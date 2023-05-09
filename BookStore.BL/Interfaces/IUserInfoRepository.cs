using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{
    public interface IUserInfoRepository
    {
        public Task<UserInfo?> GetUserInfoAsync(string email, string password);
    }
}
