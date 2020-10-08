using Microsoft.EntityFrameworkCore;
using SampleAPI.Infrastructure;
using SampleAPI.Queries.Interfaces;
using SampleAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Queries
{
    public class UserQueries : IUserQueries
    {
        private readonly ApplicationDbContext _context;

        public UserQueries(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserViewModel>> GetAllUsers()
        {
            return await _context.Users.AsNoTracking()
                .Select(u => new UserViewModel
                {
                    Username = u.Username,
                    Email = u.Email,
                    IsActive = u.IsActive,
                    CreatedAt = u.CreatedAt,
                    UpdatedAt = u.UpdatedAt
                })
                .ToListAsync();
        }

        /* public async Task<UserViewModel> GetAnUser(string username)
        {

        } */
    }
}
