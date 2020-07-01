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
        public AddTwoValues addTwoValue;

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
            this.addTwoValue = new AddTwoValues();
            this.weightsConverter = new WeightsConverter();
        }

        /// <summary>
        /// one kg and thousand grams should equal
        /// </summary>
        [Test]
        public void One_KG_And_Thousand_Grams_Should_Equal()
        {
            double oneKGInGram = weightsConverter.WeightConverter(QuantityEnums.KILOGRAM_TO_GRAM, 1);
            double expectedValue = 1000;
            Assert.AreEqual(expectedValue, oneKGInGram);
        }

        /// <summary>
        /// one tonne and thousand kgs should equal
        /// </summary>
        [Test]
        public void One_Tonne_And_Thousand_KGs_Should_Equal()
        {
            double tonneToKGs = weightsConverter.WeightConverter(QuantityEnums.TONNE_TO_KILOGRAM, 1);
            double expectedValue = 1000;
            Assert.AreEqual(expectedValue, tonneToKGs);
        }

        /// <summary>
        /// one tonne and thousand grams should equal one thousand one
        /// </summary>
        [Test]
        public void One_Tonne_And_Thousand_Grams_Should_Equal_OneThousandOne()
        {
            double tonneToKGs = weightsConverter.WeightConverter(QuantityEnums.TONNE_TO_KILOGRAM, 1);
            double gram = weightsConverter.WeightConverter(QuantityEnums.KILOGRAM, 1);
            double addWeights = addTwoValue.AddTwoValue(tonneToKGs, gram);
            double expectedValue = 1001;
            Assert.AreEqual(expectedValue, addWeights);
        }

        /// <summary>
        /// one tonne and one thousand kilogram should equal
        /// </summary>
        [Test]
        public void One_Tonne_And_Thousand_Kilogram_Should_Equal()
        {
            double oneTonne = weightsConverter.WeightConverter(QuantityEnums.TONNE_TO_KILOGRAM, 1);
            double kilogram = weightsConverter.WeightConverter(QuantityEnums.KILOGRAM, 1000);
            Assert.AreEqual(oneTonne, kilogram);
        }

        [Test]
        public void When_Kilogram_And_Feet_Compare_Should_Throw_Exception()
        {
            try
            {
                double kilogram = weightsConverter.WeightConverter(QuantityEnums.KILOGRAM, 1);
                double feet = weightsConverter.WeightConverter(QuantityEnums.FEET, 1);
                Assert.AreEqual(kilogram, feet);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }
    }
}
