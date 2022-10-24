﻿namespace WSBLearn.Application
{
    public class JwtAuthenticationSettings
    {
        public string Key { get; set; }
        public int ExpireDays { get; set; }
        public string Issuer { get; set; }
    }
}
