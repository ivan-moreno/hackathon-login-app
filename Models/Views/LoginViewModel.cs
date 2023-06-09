﻿namespace HackathonLoginApp.Models.Views;

/// <summary>
/// Serves as a model for the Login page.
/// </summary>
public sealed class LoginViewModel
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool LoginSuccess { get; set; } = false;
    public bool UsernameNotFound { get; set; } = false;
    public bool EmptyPassword { get; set; } = false;
    public bool WrongPassword { get; set; } = false;
}
