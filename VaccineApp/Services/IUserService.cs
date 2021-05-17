﻿namespace VaccineApp.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using VaccineApp.DTO;
    using VaccineApp.Entities;

    public interface IUserService
    {
        Task AddUserAsync(User user);

        Task DeleteUserAsync(int id);

        Task<UserDto> GetUserAsync(int id);

        Task<List<UserDto>> GetUsersAsync();

        Task UpdateUserAsync(User user);
    }
}