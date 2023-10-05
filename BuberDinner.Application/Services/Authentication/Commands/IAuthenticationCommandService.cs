﻿namespace BuberDinner.Application.Services.Authentication.Commands;
using BuberDinner.Application.Services.Authentication.Common;



public interface IAuthenticationCommandService
{
    AuthenticationResult Register(string firstName, string lastName, string email, string password);
}