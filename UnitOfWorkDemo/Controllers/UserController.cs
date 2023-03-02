using Abstractions.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Models.InputDtos;
using Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Get the list of product
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUserList()
        {
            var users = await _userService.GetAll();
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        /// <summary>
        /// Add a new user
        /// </summary>
        /// <param name="productDetails"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserDto dto)
        {
            var isUserCreated = await _userService.Create(dto);

            if (isUserCreated)
            {
                return Ok(isUserCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
