using Models.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;

namespace WebApi.Business
{
    public class UserBusiness
    {
        public List<Users> GetUserList()
        {

            using (var ctx = new ReplyProjectContext())
            {
                var users = ctx.users.ToList();
                return users;
            }
        }

        public bool DeleteUser(int id)
        {
            using (var ctx = new ReplyProjectContext())
            {
                try
                {
                    var user = ctx.users.Where(x => x.Id == id).FirstOrDefault();
                    ctx.Remove(user);
                    ctx.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public bool AddUser(Users user)
        {
            using (var ctx = new ReplyProjectContext())
            {
                try
                {
                    ctx.Add(user);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }

            }
        }

        public bool UpdateUser(Users user)
        {
            using (var ctx = new ReplyProjectContext())
            {
                try
                {
                    var updateUser = ctx.users.Where(x => x.Id == user.Id).FirstOrDefault();
                    updateUser.Name = user.Name;
                    updateUser.Age = user.Age;
                    updateUser.Gender = user.Gender;
                    ctx.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
    }
}

