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
        
            //action
            BMW car=new BMW();
            car.velocity = 10;
            //act
            var Distance = 20;
            var result=car.TimeToCoverDistance(Distance);

            // Numeric assert
            Assert.InRange(result,2,5);
            Assert.NotInRange(result,5,10);
        }
        
    }
}