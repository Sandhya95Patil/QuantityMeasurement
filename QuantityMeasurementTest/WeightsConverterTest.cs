using NUnit.Framework;
using QuantityMeasurement.Service;
using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Enum.QuantityEnum;

namespace QuantityMeasurementTest
{
    public class WeightsConverterTest
    {
        public AddTwoValues addTwoValue;
        public WeightsConverter weightsConverter;

        [SetUp]
        public void Setup()
        {
            this.addTwoValue = new AddTwoValues();
            this.weightsConverter = new WeightsConverter();
        }

        [Test]
        public void One_KG_And_Thousand_Grams_Should_Equal()
        {
            double oneKGInGram = weightsConverter.WeightConverter(QuantityEnums.KILOGRAM_TO_GRAM, 1);
            double expectedValue = 1000;
            Assert.AreEqual(expectedValue, oneKGInGram);
        }

        [Test]
        public void One_Tonne_And_Thousand_KGs_Should_Equal()
        {
            double tonneToKGs = weightsConverter.WeightConverter(QuantityEnums.TONNE_TO_KILOGRAM, 1);
            double expectedValue = 1000;
            Assert.AreEqual(expectedValue, tonneToKGs);
        }

        [Test]
        public void One_Tonne_Thousand_Grams_Should_Equal_OneThousandOne()
        {
            double tonneToKGs = weightsConverter.WeightConverter(QuantityEnums.TONNE_TO_KILOGRAM, 1);
            double gram = weightsConverter.WeightConverter(QuantityEnums.KILOGRAM, 1);
            double addWeights = addTwoValue.AddTwoValue(tonneToKGs, gram);
            double expectedValue = 1001;
            Assert.AreEqual(expectedValue, addWeights);
        }
    }
}
