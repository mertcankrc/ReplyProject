using Models.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;

namespace WebApi.Business
{
    public class CarBusiness
    {
        public List<Cars> GetCarList()
        {

                using (var ctx = new ReplyProjectContext())
                {
                    var cars =  ctx.cars.ToList();
                    return cars;
                }
        }

        public bool DeleteCar(int id)
        {
            using (var ctx = new ReplyProjectContext())
            {
                try
                {
                    var car = ctx.cars.Where(x => x.Id == id).FirstOrDefault();
                    ctx.Remove(car);
                    ctx.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
               
            }
        }

        public bool AddCar(Cars car)
        {
            using (var ctx = new ReplyProjectContext())
            {
                try
                {
                    ctx.Add(car);
                    ctx.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public bool UpdateCar(Cars car)
        {
            using (var ctx = new ReplyProjectContext())
            {
                try
                {
                    var updateCar = ctx.cars.Where(x => x.Id == car.Id).FirstOrDefault();
                    updateCar.Infotainment = car.Infotainment;
                    updateCar.Model = car.Model;
                    updateCar.Engine = car.Engine;
                    updateCar.Design = car.Design;
                    updateCar.Coordination = car.Coordination;
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
