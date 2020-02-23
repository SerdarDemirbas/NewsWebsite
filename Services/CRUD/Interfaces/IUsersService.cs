﻿using DataAccess.Entities;
using Services.CRUD.DTOs;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Services.CRUD.Interfaces
{
    public interface IUsersService : IBaseCRUDService<User>
    {
        Task<UsersServiceResultDTO> CreateAsync(User userDb, string password);
        Task<UsersServiceResultDTO> CreateAsync(User userDb);
        Task<SignInResultDTO> PasswordSignInAsync(string username, string password);
        bool IsSignedIn(IPrincipal principal);
        Task SignOutAsync();
        Task<string> GeneratePasswordResetTokenAsync(User userDb);
        Task<User> FindByIdAsync(string userId);
        Task<UsersServiceResultDTO> ResetPasswordAsync(User userDb, string passwordResetToken, string newPassword);
        Task<UsersServiceResultDTO> AddToRoleAsync(User userDb, string role);
    }
}