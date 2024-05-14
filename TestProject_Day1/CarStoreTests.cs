using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Day1
{
    public class CarStoreTests
    {
        [Fact]
        public void AddCarsTests_addCars_listCars()
        {
            //arrange
            var carStore = new CarStore();
            var Car=new BMW() { velocity=1};
            //act
            carStore.AddCar(Car);
            //collection assert
            Assert.NotEmpty(carStore.cars);

        }
    }   
}
