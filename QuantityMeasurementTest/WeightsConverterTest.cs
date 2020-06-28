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
    }
}
