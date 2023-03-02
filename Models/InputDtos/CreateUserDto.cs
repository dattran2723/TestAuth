﻿using System.ComponentModel.DataAnnotations;

namespace Models.InputDtos
{
    public class CreateUserDto
    {
        [Required]
        public string Email { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; }  = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
