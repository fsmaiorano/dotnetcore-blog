using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserLogic _userLogic;

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        [HttpGet]
        [Route("/user")]
        public IEnumerable<UserModel> Index()
        {
            return _userLogic.GetAll();
        }

        [HttpGet]
        [Route("/user/{id}")]
        public UserModel Index(int id)
        {
            return _userLogic.GetUserById(id);
        }

        [HttpPost]
        [Route("/user")]
        public void Store(UserModel user)
        {
            _userLogic.StoreUser(user);
        }
    }
}