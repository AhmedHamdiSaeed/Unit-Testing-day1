using CarFactoryLibrary;

namespace TestProject_Day1
{
    public class CarTests
    {
        [Fact]
        public void StopTests_velocity10_velocity0()
        {
            //arrange
            BMW car = new BMW();
            car.velocity = 10;

            //act
            car.Stop();

            //Boolean assert
            Assert.True(car.velocity == 0);
        }
        [Fact]
        public void TimeToCoverDistanceTests_velocity10andDistanse20_time2()
        {

            //arrange
            BMW car =new BMW();
            car.velocity = 10;
            //act
            var Distance = 20;
            var result=car.TimeToCoverDistance(Distance);

            // Numeric assert
            Assert.InRange(result,2,5);
            Assert.NotInRange(result,5,10);
        }
        [Fact]
        public void GetDirectionTests_setBackward_Backward()
        {
            //arrange
            BMW car = new BMW();
            car.drivingMode=DrivingMode.Backward; 

            //act
            var result=car.GetDirection();
            //string assert
            Assert.NotEmpty(result);
            Assert.Contains("Backward",result);
            Assert.StartsWith("Back", result);
            Assert.EndsWith("ard",result);
            
        }
        [Fact]
        public void GetMyCarTests_getCar_car()
        {
            //arrange
            var car = new BMW();
            //act
            var myCar=car.GetMyCar();
            //reference assert
            Assert.NotNull(myCar);

            //type assert
            Assert.IsType<BMW>(myCar);
            Assert.IsAssignableFrom<Car>(myCar);
            


        }
    }
}