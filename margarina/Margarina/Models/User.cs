﻿using System.ComponentModel.DataAnnotations;

namespace Margarina.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
