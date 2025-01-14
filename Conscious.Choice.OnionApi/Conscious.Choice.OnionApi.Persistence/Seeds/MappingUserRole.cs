﻿using Conscious.Choice.OnionApi.Domain.Enum;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Conscious.Choice.OnionApi.Persistence.Seeds
{
    public static class MappingUserRole
    {
        public static List<IdentityUserRole<string>> IdentityUserRoleList()
        {
            return new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>
                {
                    RoleId = Constants.Basic,
                    UserId = Constants.BasicUser
                },
                new IdentityUserRole<string>
                {
                    RoleId = Constants.SuperAdmin,
                    UserId = Constants.SuperAdminUser
                },
                new IdentityUserRole<string>
                {
                    RoleId = Constants.Admin,
                    UserId = Constants.SuperAdminUser
                },
                new IdentityUserRole<string>
                {
                    RoleId = Constants.Moderator,
                    UserId = Constants.SuperAdminUser
                },
                new IdentityUserRole<string>
                {
                    RoleId = Constants.Basic,
                    UserId = Constants.SuperAdminUser
                }
            };
        }
    }
}
