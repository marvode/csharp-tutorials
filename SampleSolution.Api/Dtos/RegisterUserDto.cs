﻿using System.ComponentModel.DataAnnotations;

namespace SampleSolution.Api.Dtos;

public class RegisterUserDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}