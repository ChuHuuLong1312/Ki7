﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    internal class CarManagement
    {
        private static CarManagement instance = null;
        private static readonly object instanceLock = new object();
        private CarManagement() { }
        public static CarManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarManagement();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Car> GetCarList()
        {
            List<Car> cars;
            try {
                var myStockDB = new MyStockContext();
                cars =myStockDB.Cars.ToList();
            
            }catch(Exception ex) {
                throw new Exception(ex.Message);
            }
            return cars;
        }
        public Car GetCarByID(int carID) {
            Car car = null;
            try {
                var myStockDB = new MyStockContext();
                car = myStockDB.Cars.FirstOrDefault(car =>car.CarId == carID); 
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return car;
        
        }
        public void AddNew(Car car)
        {
            try
            {
                Car c = GetCarByID(car.CarId);
                if (c == null)
                {
                    var myStockDB = new MyStockContext();
                    myStockDB.Cars.Add(car);
                    myStockDB.SaveChanges();
                }
                else
                {
                    throw new Exception("the car is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Update(Car car)
        {
            try {
                Car c = GetCarByID(car.CarId);
                if (c != null)
                {
                    var myStockDB = new MyStockContext();
                    myStockDB.Entry<Car>(car).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    myStockDB.SaveChanges();
                }
                else {
                    throw new Exception("the car does not already exist");
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public void Delete(Car car)
        {
            try
            {
                Car _car = GetCarByID(car.CarId);
                if (_car != null)
                {
                    var myStockDB = new MyStockContext();
                    myStockDB.Cars.Remove(car);
                    myStockDB.SaveChanges();
                }
                else
                {
                    throw new Exception("the car does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
