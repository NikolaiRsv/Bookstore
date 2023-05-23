using System;
using System.Collections.Generic;
using System.Linq;
namespace BookStore.Models.Requests
{
    public class AddUserInfoRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}