﻿using Microsoft.AspNetCore.Mvc;
using Models.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Business;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        [HttpGet]
        public List<Cars> GetCarList()
        {
            CarBusiness carB = new CarBusiness();
            return carB.GetCarList();
        }

        [HttpDelete]
        public bool DeleteCarById(int id)
        {
            CarBusiness carB = new CarBusiness();
            return carB.DeleteCar(id);
        }

        [HttpPost]
        public bool AddCar(Cars car)
        {
            CarBusiness carB = new CarBusiness();
            return carB.AddCar(car);
        }

        [HttpPut]
        public bool UpdateCar(Cars car)
        {
            CarBusiness carB = new CarBusiness();
            return carB.UpdateCar(car);
        }
    }
}
