﻿using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
    }
}
