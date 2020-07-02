//-----------------------------------------------------------------------
// <copyright file="WeightsConverterTest.cs" company="BridgeLabz">
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
    /// Weight convert test class
    /// </summary>
    public class WeightsConverterTest
    {
        /// <summary>
        /// initialise the instance
        /// </summary>
        public Adition addTwoValue;

        /// <summary>
        /// initialise the instance
        /// </summary>
        public WeightsConverter weightsConverter;

        /// <summary>
        /// set the instance 
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.addTwoValue = new Adition();
            this.weightsConverter = new WeightsConverter();
        }

        /// <summary>
        /// one kg and thousand grams should equal
        /// </summary>
        [Test]
        public void Given_One_KG_And_Thousand_Grams_Should_Equal()
        {
            double oneKGInGram = weightsConverter.WeightConverter(QuantityEnums.KILOGRAM_TO_GRAM, 1);
            Assert.AreEqual(expected: 1000, oneKGInGram);
        }

        /// <summary>
        /// one tonne and thousand kgs should equal
        /// </summary>
        [Test]
        public void Given_One_Tonne_And_Thousand_KGs_Should_Equal()
        {
            double tonneToKGs = weightsConverter.WeightConverter(QuantityEnums.TONNE_TO_KILOGRAM, 1);
            Assert.AreEqual(expected: 1000, tonneToKGs);
        }

        /// <summary>
        /// one tonne and thousand grams should equal one thousand one kilogram
        /// </summary>
        [Test]
        public void One_Tonne_And_Thousand_Grams_Should_Equal_OneThousandOne_Kilogram()
        {
            double tonneToKGs = weightsConverter.WeightConverter(QuantityEnums.TONNE_TO_KILOGRAM, 1);
            double gram = weightsConverter.WeightConverter(QuantityEnums.KILOGRAM, 1);
            double result = addTwoValue.AddTwoValue(tonneToKGs, gram);
            Assert.AreEqual(expected: 1001, result);
        }

        /// <summary>
        /// one tonne and one thousand kilogram should equal
        /// </summary>
        [Test]
        public void Given_One_Tonne_And_Thousand_Kilogram_Should_Equal()
        {
            double oneTonne = weightsConverter.WeightConverter(QuantityEnums.TONNE_TO_KILOGRAM, 1);
            Assert.AreEqual(expected: 1000, oneTonne);
        }

        /// <summary>
        /// Given feet in temperature method then should throw exception
        /// </summary>
        [Test]
        public void Given_Feet_In_Weight_Method_Then_Should_Throw_Exception()
        {
            try
            {
                weightsConverter.WeightConverter(QuantityEnums.FEET, 1);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }

        /// <summary>
        /// Given inch in temperature method then should throw exception
        /// </summary>
        [Test]
        public void Given_Inch_In_Weight_Method_Then_Should_Throw_Exception()
        {
            try
            {
                weightsConverter.WeightConverter(QuantityEnums.INCH, 1);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }
    }
}
