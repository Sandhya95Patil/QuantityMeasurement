using NUnit.Framework;
using QuantityMeasurement.Enum;
using QuantityMeasurement.Interface;
using QuantityMeasurement.Service;
using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Enum.QuantityEnum;

namespace QuantityMeasurementTest
{
    class TemperatureConverterTest
    {
        public TemperatureConverter temperatureConverter;
        [SetUp] 
        public void Setup()
        {
            this.temperatureConverter = new TemperatureConverter();
        }

        [Test]
        public void Given212_Farenheit_Equal_100C()
        {
            double farenhiet = temperatureConverter.TempConverter(QuantityEnums.FARENHIET_TO_CELSIUS, 212);
            double expectedValue = 100;
            Assert.AreEqual(expectedValue, farenhiet);
        }
    }
}
