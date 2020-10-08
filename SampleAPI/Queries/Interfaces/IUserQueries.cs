using SampleAPI.Domain.Models;
using SampleAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Queries.Interfaces
{
    public interface IUserQueries
    {
        Task<List<UserViewModel>> GetAllUsers();
        //Task<UserViewModel> GetAnUser(string username);

    }
}
