﻿using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using BookStore.Models.Models;
using BookStore.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserInfoService _userInfoService;

        public UserInfoController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        [ProducesResponseType(StatusCodes.Status200OK,
            Type = typeof(Book))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("Login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))
                return BadRequest("Wrong e-mail and/or password");

            var result =
                await _userInfoService.GetUserInfoAsync(email, password);

            if (result != null) return Ok(result);

            return NotFound();
        }
     
        [HttpPost("Add")]
        public async Task Add([FromBody] AddUserInfoRequest user)
        {
            await _userInfoService.Add(user);
        }
    }
}