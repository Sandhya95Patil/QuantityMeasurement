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
        /// create field
        /// </summary>
        public VolumeConverter volume;

        /// <summary>
        /// create field
        /// </summary>
        public Adition addTwoValues;

        /// <summary>
        /// Set the instance 
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.volume = new VolumeConverter();
            this.addTwoValues = new Adition();
        }

        /// <summary>
        /// one gallon and 3.78 liter should equal 
        /// </summary>
        [Test]
        public void Given_1_Gallon_And_3_78_Liter_Compared_Should_Return_Same()
        {
            double gallon = volume.VolumeComverter(QuantityEnums.GALLON_TO_LETER, 1);
            double liter = volume.VolumeComverter(QuantityEnums.LITER, 3.78);
            Assert.AreEqual(gallon, liter);
        }

        /// <summary>
        /// one gallon and 3.78 liters should equal 7.56 liters
        /// </summary>
        [Test]
        public void Given_One_Gallon_Plus_3_78Liters_Equals_7_56Liters()
        {
            double gallon = volume.VolumeComverter(QuantityEnums.GALLON_TO_LETER, 1);
            double liters = volume.VolumeComverter(QuantityEnums.LITER, 3.78);
            double result = addTwoValues.AddTwoValue(gallon, liters);
            Assert.AreEqual(expected: 7.56, result);
        }

        /// <summary>
        /// one liter and one thousand mililiter should equal two liter
        /// </summary>
        [Test]
        public void Given_One_Liter_Plus_Thousand_Mililiter_Should_Equal_Two_Liter()
        {
            double liter = volume.VolumeComverter(QuantityEnums.LITER, 1);
            double miliLiter = volume.VolumeComverter(QuantityEnums.MILILITER_TO_LITER, 1000);
            double result = addTwoValues.AddTwoValue(liter, miliLiter);
            Assert.AreEqual(expected: 2, result);
        }

        /// <summary>
        /// One liter and one thousand mililiter should equal 
        /// </summary>
        [Test]
        public void Given_One_Liter_And_Thousand_Mililiter_Should_Equal_Same()
        {
            double liter = volume.VolumeComverter(QuantityEnums.LITER, 1);
            double mililiter = volume.VolumeComverter(QuantityEnums.MILILITER_TO_LITER, 1000);
            Assert.AreEqual(liter, mililiter);
        }

        /// <summary>
        /// Two liters and two thousand mililiter should four liters
        /// </summary>
        [Test]
        public void Given_Two_Liter_And_Two_Thousand_MiliLiter_Should_Equal_Four_Liter()
        {
            double liter1 = volume.VolumeComverter(QuantityEnums.LITER, 2);
            double mililiterInLiter = volume.VolumeComverter(QuantityEnums.MILILITER_TO_LITER, 2000);
            double result = addTwoValues.AddTwoValue(liter1, mililiterInLiter);
            Assert.AreEqual(expected: 4, result);
        }

        /// <summary>
        /// Given kilogram in volume converter method then should throw exception
        /// </summary>
        [Test]
        public void Given_Kilogram_In_Volume_Method_Then_Should_Throw_Exception()
        {
            try
            {
                volume.VolumeComverter(QuantityEnums.KILOGRAM, 1);
            }
            catch(QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }

        /// <summary>
        /// Given tonne in volume converter method then should throw exception
        /// </summary>
        [Test]
        public void Given_Tonne_In_Volume_Method_Should_Throw_Exception()
        {
            try
            {
                volume.VolumeComverter(QuantityEnums.TONNE, 1);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }
    }
}
