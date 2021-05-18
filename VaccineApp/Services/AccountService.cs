﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VaccineApp.DTO;
using VaccineApp.Entities;
using VaccineApp.Repositories;

namespace VaccineApp.Services
{
    public class AccountService : IAccountService
    {
        private ITokenService _tokenService;
        private IGenericRepo<User> _userRepo;
        private DatabaseContext _context;

        public AccountService(ITokenService tokenService, IGenericRepo<User> userRepo, DatabaseContext context)
        {
            _tokenService = tokenService;
            _userRepo = userRepo;
            _context = context;
        }

        public async Task<AccountDto> LoginAsync(string email, string password)
        {
            var user = await _context.Users.Include(x => x.Login).SingleOrDefaultAsync(x => x.Login.Email == email);
            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username");
            }
            using var hmac = new HMACSHA512(user.Login.PasswordSalt);
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < hash.Length; i++)
            {
                if (hash[i] != user.Login.PasswordHash[i])
                {
                    throw new UnauthorizedAccessException("Invalid password");
                }
            }
            return new AccountDto
            {
                Email = user.Login.Email,
                Token = _tokenService.CreateToken(user.Login),
            };
        }

        public async Task<AccountDto> RegisterAsync(RegisterDto registerDto)
        {
            using var hmac = new HMACSHA512();
            User user = new User
            {
                FirstName = registerDto.FirstName.ToLower(),
                Surname = registerDto.SurName.ToLower(),
                BirthDate = registerDto.BirthDate,
                Address = registerDto.Address,
                Login = new Login
                {
                    Email = registerDto.Email,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                    PasswordSalt = hmac.Key,
                },
                Appointments = new System.Collections.Generic.List<Appointment>(),
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return new AccountDto
            {
                Email = user.Login.Email,
                Token = _tokenService.CreateToken(user.Login),
            };
        }

        public async Task<bool> UserExists(string email)
        {
            return await _context.Users.AnyAsync(x => x.Login.Email == email);
        }
    }
}