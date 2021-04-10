﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OtoMoto.Database;
using OtoMoto.Models;
using OtoMoto.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtoMoto.Services
{
    public class AccountService
    {
        private readonly Context _context;
        private readonly IPasswordHasher<User> _hasher;

        public AccountService(Context context, IPasswordHasher<User> hasher)
        {
            _context = context;
            _hasher = hasher;
        }

        public async Task<User> GetUserOrNull(AccountInfo info)
        {
            var user = await _context
                             .Users
                             .Include(x => x.Role)
                             .FirstOrDefaultAsync(x => x.Email == info.Email);

            if (user == null)
                return null;

            var result = _hasher.VerifyHashedPassword(user, user.PasswordHash, info.Password);
            if (result == PasswordVerificationResult.Success)
            {
                return user;
            }

            return null;
        }

        public async Task<(bool Success, string Message, User User)> TryRegister(AccountInfo info)
        {
            var alreadyExists = await _context.Users.AnyAsync(x => x.Email.ToUpper() == info.Email.ToUpper());

            if (alreadyExists)
                return (false, "Użytkownik o takim adresie E-mail już istnieje", null);

            var role = await _context.Roles.FirstAsync(x => x.Name == Consts.UserRoleName);

            if (string.IsNullOrWhiteSpace(info.UserName))
            {
                info.UserName = "NazwaUżytkownika";
            }

            var user = new User
            {
                Email = info.Email,
                Role = role,
                UserName = info.UserName
            };

            user.PasswordHash = _hasher.HashPassword(user, info.Password);

            await _context.AddAsync(user);

            await _context.SaveChangesAsync();

            return (true, "", user);
        }
    }
}
