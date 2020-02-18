using Application.Interfaces;
using Application.Models;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserService _userService;
        private readonly IRepository<UserModel> _userRepository;

        public UserLogic(IUserService userService, IRepository<UserModel> userRepository)
        {
            _userService = userService;
            _userRepository = userRepository;
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _userRepository.GetAll();
        }

        public UserModel GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void StoreUser(UserModel user)
        {
            var userEntity = new UserEntity
            {
                Name = user.Name,
                Email = user.Email,
                Avatar = user.Avatar,
                Surname = user.Surname,
                Nickname = user.Nickname,
                Password = user.Password,
            };

            _userService.Store(userEntity);
        }

        public void StoreUser(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
