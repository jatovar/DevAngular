using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevAngular.Business.Interfaces;
using DevAngular.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevAngular.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        ICarManager _carManager;
        public CarController(ICarManager carManager)
        {
           _carManager = carManager;
        }

        [HttpGet]
        public IEnumerable<Car> Get()
        {
            var data = _carManager.GetCars();
            return data;
        }

        [HttpPut]
        public dynamic Put([FromBody]Car car)
        {
            var result = _carManager.CreateCar(car);
            return new
            {
                success = result
            };
        }

    }
}
