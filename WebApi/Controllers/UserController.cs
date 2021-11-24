using Microsoft.AspNetCore.Mvc;
using Models.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Business;

namespace WebApi.Controllers
{

        [ApiController]
        [Route("[controller]")]
        public class UserController : Controller
        {
            [HttpGet]
            [Route("GetUserList")]
            public List<Users> GetUserList()
            {
                UserBusiness userB = new UserBusiness();
                return userB.GetUserList();
            }

            [HttpDelete]
            [Route("DeleteUserById")]

            public bool DeleteUserById(int id)
            {
                UserBusiness userB = new UserBusiness();
                return userB.DeleteUser(id);
            }

            [HttpPost]
            [Route("AddUser")]

            public bool AddUser(Users user)
            {
                UserBusiness userB = new UserBusiness();
                return userB.AddUser(user);
            }

            [HttpPut]
            [Route("UpdateUser")]

            public bool UpdateUser(Users user)
            {
                UserBusiness userB = new UserBusiness();
                return userB.UpdateUser(user);
            }
        }
    
}
