﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtoMoto.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string PasswordHash { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public List<Offer> Offers { get; set; } = new List<Offer>();

        public int? RoleId { get; set; }

        public Role Role { get; set; }
    }
}
