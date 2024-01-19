﻿using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set;}
    }
}
