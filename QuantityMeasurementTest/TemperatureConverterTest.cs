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
            Assert.AreEqual(expected: 100, celsius);
        }

        /// <summary>
        /// convert 100 celsius to 212 farenheit
        /// </summary>
        [Test]
        public void Given100_Celsius_Should_Equal_212_Farenheit()
        {
            double farenhiet = temperatureConverter.TempConverter(QuantityEnums.CELSIUS_TO_FARENHIET, 100);
            Assert.AreEqual(expected: 212, farenhiet);
        }

        /// <summary>
        /// Given liter in temperature method then should throw exception
        /// </summary>
        [Test]
        public void Given_Liter_In_Temperature_Method_Then_Should_Throw_Exception()
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
        /// Given feet in temperature method then should throw exception
        /// </summary>
        [Test]
        public void Given_Feet_In_Temperature_Method_Then_Should_Throw_Exception()
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
