using System;
using System.Collections.Generic;
using DevAngular.Business.Interfaces;
using DevAngular.Data.Entities;
using DevAngular.Data.Repositories;

namespace DevAngular.Business
{
    public class CarManager : ICarManager
    {
        readonly ICarRepository _carRepository;

        public CarManager(ICarRepository carRepository) 
        {
            _carRepository = carRepository;
        }
        public bool CreateCar(Car car)
        {
            return _carRepository.CreateCar(car);
        }

        public bool DeleteCar(int id)
        {
            return _carRepository.DeleteCar(id);
        }

        public IList<Car> GetCars()
        {
            return _carRepository.GetCars();
        }

        public bool UpdateCar(Car car, int id)
        {
            return _carRepository.UpdateCar(car, id);
        }
    }

}