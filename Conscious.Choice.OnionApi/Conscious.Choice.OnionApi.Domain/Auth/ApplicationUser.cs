﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Conscious.Choice.OnionApi.Domain.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
        public ICollection<Entities.RDeputyUser> DeputyUsers { get; set; }
        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}