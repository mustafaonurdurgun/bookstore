﻿namespace Business.Models.Request.Functional;

public class LoginDto
{
    public string Email { get; set; } = default!;
    public string PasswordSalt { get; set; } = default!;
}