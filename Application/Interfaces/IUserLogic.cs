using Application.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IUserLogic
    {
        void StoreUser(UserModel user);
        UserModel GetUserById(int id);
        IEnumerable<UserModel> GetAll();
    }
}
