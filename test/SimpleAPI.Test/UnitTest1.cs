using System;
using Xunit;
using SimepleAPI.Controllers;
using System.Collections.Generic;
using SimepleAPI;
using System.Linq;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Theo", returnValue.Value);
        }

        [Fact]
        public void GetArrayLength()
        {
           var lengthOfArray = controller.Get().ToList();
            Assert.Equal(5 , lengthOfArray.Count());
        }

    }
}
