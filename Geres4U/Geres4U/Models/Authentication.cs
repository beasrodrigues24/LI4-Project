﻿using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    public class Authentication
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}