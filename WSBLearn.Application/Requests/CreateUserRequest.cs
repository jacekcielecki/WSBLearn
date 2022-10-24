﻿namespace WSBLearn.Application.Requests
{
    public  class CreateUserRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public int RoleId { get; set; }
    }
}
