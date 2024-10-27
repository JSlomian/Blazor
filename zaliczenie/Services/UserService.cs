using System;
using Microsoft.EntityFrameworkCore;
using zaliczenie.Data;
using zaliczenie.Models;

namespace zaliczenie.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //public async Task<List<User>> GetUsersAsync()
        //{
        //    // Fetch the ApplicationUser list from the database
        //    var applicationUsers = await _dbContext.Users.ToListAsync();

        //    // Manually map ApplicationUser to User
        //    var users = applicationUsers.Select(appUser => new User
        //    {
        //        Id = appUser.Id,
        //        Email = appUser.Email,
        //        Role = appUser.Roles
        //    }).ToList();

        //    return users;
        //}
    }
}
