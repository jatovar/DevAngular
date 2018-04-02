using System;
using System.Collections.Generic;
using  DevAngular.Data.Entities;

namespace DevAngular.Business.Interfaces
{
    public interface ICarManager
    {
        bool CreateCar(Car car);
        bool UpdateCar(Car car, int id);
        bool DeleteCar(int id);
        IList<Car> GetCars();
    }
}
