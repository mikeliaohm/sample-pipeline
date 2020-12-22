using System;
using Xunit;
using SamplePipeline.Controllers;

namespace SamplePipeline.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsMyName() 
        {
            var returnValue = controller.Get(1);
            Assert.Equal("something", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
