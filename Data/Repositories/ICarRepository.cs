using System.Collections.Generic;
using  DevAngular.Data.Entities;

namespace DevAngular.Data.Repositories
{
    public interface ICarRepository
    {
        bool CreateCar(Car car);
        bool UpdateCar(Car car, int id);
        bool DeleteCar(int id);
        IList<Car> GetCars();
    }
}