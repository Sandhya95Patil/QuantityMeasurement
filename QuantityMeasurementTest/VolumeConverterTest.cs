//-----------------------------------------------------------------------
// <copyright file="VolumeConverterTest.cs" company="BridgeLabz">
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
    /// volume converter test class
    /// </summary>
    public class VolumeConverterTest
    {
        /// <summary>
        /// Declare property
        /// </summary>
        public VolumeConverter volume;

        /// <summary>
        /// Declare property
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
        /// one gallon and 3.78 liters should equal 7.56 liters
        /// </summary>
        [Test]
        public void One_Gallon_Plus_3_78Liters_Equals_Liters_7_56()
        {
            double gallon = volume.VolumeComverter(QuantityEnums.GALLON_TO_LETER, 1);
            double liters = volume.VolumeComverter(QuantityEnums.LITER, 3.78);
            double addVolume = addTwoValues.AddTwoValue(gallon, liters);
            double expectedValue = 7.56;
            Assert.AreEqual(expectedValue, addVolume);
        }

        /// <summary>
        /// one liter and one thousand mililiter should equal two liter
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

        /// <summary>
        /// One liter and one thousand mililiter should equal 
        /// </summary>
        [Test]
        public void One_Liter_And_Thousand_Mililiter_Should_Equal_Same()
        {
            double liter = volume.VolumeComverter(QuantityEnums.LITER, 1);
            double mililiter = volume.VolumeComverter(QuantityEnums.MILILITER_TO_LITER, 1000);
            Assert.AreEqual(liter, mililiter);
        }

        /// <summary>
        /// Two liters and two thousand mililiter should four liters
        /// </summary>
        [Test]
        public void Two_Liter_And_Two_Thousand_MiliLiter_Should_Equal_Four_Liter()
        {
            double liter1 = volume.VolumeComverter(QuantityEnums.LITER, 2);
            double mililiterInLiter = volume.VolumeComverter(QuantityEnums.MILILITER_TO_LITER, 2000);
            double addValues = addTwoValues.AddTwoValue(liter1, mililiterInLiter);
            Assert.AreEqual(expected: 4, addValues);
        }

        /// <summary>
        /// Liter and kilogram when compare should throw exception
        /// </summary>
        [Test]
        public void When_Liter_And_Kilogram_Compare_Should_Throw_Exception()
        {
            try
            {
                double liter = volume.VolumeComverter(QuantityEnums.LITER, 1);
                double kilogram = volume.VolumeComverter(QuantityEnums.KILOGRAM, 1);
                Assert.AreEqual(liter, kilogram);
            }
            catch(QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }

        /// <summary>
        /// Gallon and tonne when compare should throw exception
        /// </summary>
        [Test]
        public void When_Gallon_And_Tonne_Compare_Should_Throw_Exception()
        {
            try
            {
                double tonne = volume.VolumeComverter(QuantityEnums.TONNE, 1);
                double gallonInLiter = volume.VolumeComverter(QuantityEnums.GALLON_TO_LETER, 1);
                Assert.AreEqual(tonne, gallonInLiter);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }
    }
}
