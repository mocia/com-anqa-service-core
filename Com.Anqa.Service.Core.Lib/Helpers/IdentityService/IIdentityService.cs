﻿namespace Com.Anqa.Service.Core.Lib.Helpers.IdentityService
{
    public interface IIdentityService
    {
        string Username { get; set; }
        string Token { get; set; }
        int TimezoneOffset { get; set; }
    }
}