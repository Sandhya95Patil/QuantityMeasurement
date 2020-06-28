using NUnit.Framework;
using QuantityMeasurement.Service;
using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Enum.QuantityEnum;

namespace QuantityMeasurementTest
{
    public class VolumeConverterTest
    {
        public VolumeConverter volume;
        public AddTwoValues addTwoValues;

        [SetUp]
        public void Setup()
        {
            this.volume = new VolumeConverter();
            this.addTwoValues = new AddTwoValues();
        }

        [Test]
        public void When_Gallon_And_Liter_Compared_Should_Return_Same()
        {
            double gallon = volume.VolumeComverter(QuantityEnums.GALLON_TO_LETER, 1);
            double liter = volume.VolumeComverter(QuantityEnums.LITER, 3.78);
            Assert.AreEqual(gallon, liter);
        }

        [Test]
        public void One_Gallon_And_3_78Liters_Equals_Liters_7_57()
        {
            double gallon = volume.VolumeComverter(QuantityEnums.GALLON_TO_LETER, 1);
            double liters = volume.VolumeComverter(QuantityEnums.LITER, 3.78);
            double addVolume = addTwoValues.AddTwoValue(gallon, liters);
            double expectedValue = 7.56;
            Assert.AreEqual(expectedValue, addVolume);
        }
    }
}
