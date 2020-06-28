//-----------------------------------------------------------------------
// <copyright file="VolumeConverterTest.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Sandhya Patil"/>
//-----------------------------------------------------------------------
namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement.Service;
    using static QuantityMeasurement.Enum.QuantityEnum;

    /// <summary>
    /// volume converter test class
    /// </summary>
    public class VolumeConverterTest
    {
        /// <summary>
        /// Initialise instance
        /// </summary>
        public VolumeConverter volume;

        /// <summary>
        /// Initialise instance
        /// </summary>
        public AddTwoValues addTwoValues;

        /// <summary>
        /// Set the instance 
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.volume = new VolumeConverter();
            this.addTwoValues = new AddTwoValues();
        }

        /// <summary>
        /// one gallon and 3.78 liter should equal 
        /// </summary>
        [Test]
        public void When_1_Gallon_And_3_78_Liter_Compared_Should_Return_Same()
        {
            double gallon = volume.VolumeComverter(QuantityEnums.GALLON_TO_LETER, 1);
            double liter = volume.VolumeComverter(QuantityEnums.LITER, 3.78);
            Assert.AreEqual(gallon, liter);
        }

        /// <summary>
        /// one gallon and 3.78 liters should equal 7.57 liters
        /// </summary>
        [Test]
        public void One_Gallon_And_3_78Liters_Equals_Liters_7_57()
        {
            double gallon = volume.VolumeComverter(QuantityEnums.GALLON_TO_LETER, 1);
            double liters = volume.VolumeComverter(QuantityEnums.LITER, 3.78);
            double addVolume = addTwoValues.AddTwoValue(gallon, liters);
            double expectedValue = 7.56;
            Assert.AreEqual(expectedValue, addVolume);
        }

        /// <summary>
        /// one liter and thousand mililiter should equal two liter
        /// </summary>
        [Test]
        public void One_Liter_Plus_Thousand_Mililiter_Should_Equal_Two_Liter()
        {
            double liter = volume.VolumeComverter(QuantityEnums.LITER, 1);
            double miliLiter = volume.VolumeComverter(QuantityEnums.MILILITER_TO_LITER, 1000);
            double addVolums = addTwoValues.AddTwoValue(liter, miliLiter);
            double expectedValue = 2;
            Assert.AreEqual(expectedValue, addVolums);
        }
    }
}
