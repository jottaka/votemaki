﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Votemaki.Core.Entities.MainEntities
{
    public class TemakiUser : IdentityUser<string>
    {
        [Required]
        [MaxLength(1), MinLength(150)]
        public string Name { get; set; }

        [Required]
        public DateTimeOffset RegisteredAt { get; set; }

        public Guid RegionId { get; set; }
        public Region Region { get; set; }

        public IEnumerable<Role> Roles { get; set; }
        public IEnumerable<Identification> Identifications { get; set; }
    }
}