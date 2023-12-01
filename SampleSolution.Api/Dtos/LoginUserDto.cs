﻿using System.ComponentModel.DataAnnotations;

namespace SampleSolution.Api.Dtos;

public class LoginUserDto
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}