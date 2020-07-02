//-----------------------------------------------------------------------
// <copyright file="TemperatureConverterTest.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement.Exception;
    using QuantityMeasurement.Service;
    using static QuantityMeasurement.Enum.QuantityEnum;

    /// <summary>
    /// Class Temprature converter
    /// </summary>
    class TemperatureConverterTest
    {
        /// <summary>
        /// Create instance
        /// </summary>
        public TemperatureConverter temperatureConverter;

        /// <summary>
        /// Set the instance
        /// </summary>
        [SetUp] 
        public void Setup()
        {
            this.temperatureConverter = new TemperatureConverter();
        }

        /// <summary>
        /// Convert 212 farenheit to 100 celsius
        /// </summary>
        [Test]
        public void Given212_Farenheit_Equal_100C()
        {
            double celsius = temperatureConverter.TempConverter(QuantityEnums.FARENHIET_TO_CELSIUS, 212);
            double expectedValue = 100;
            Assert.AreEqual(expectedValue, celsius);
        }

        /// <summary>
        /// convert celsius to farenheit
        /// </summary>
        [Test]
        public void Celsius_To_Farenheit()
        {
            double farenhiet = temperatureConverter.TempConverter(QuantityEnums.CELSIUS_TO_FARENHIET, 100);
            double expectedValue = 212;
            Assert.AreEqual(expectedValue, farenhiet);
        }

        /// <summary>
        /// Liter and farenheit when compare should throw exception
        /// </summary>
        [Test]
        public void Liter_And_Farenheit_When_Compare_Should_Throw_Exception()
        {
            try
            {
                temperatureConverter.TempConverter(QuantityEnums.LITER, 1);
            }
            catch(QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }

        /// <summary>
        /// Feet and celsius when compare should throw exception
        /// </summary>
        [Test]
        public void Feet_And_Celsius_When_Compare_Should_Throw_Exception()
        {
            try
            {
                temperatureConverter.TempConverter(QuantityEnums.FEET, 1);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }
    }
}
