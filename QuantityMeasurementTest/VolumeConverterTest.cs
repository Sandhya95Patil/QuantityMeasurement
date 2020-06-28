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

        [SetUp]
        public void Setup()
        {
            this.volume = new VolumeConverter();
        }

        [Test]
        public void When_Gallon_And_Liter_Compared_Should_Return_Same()
        {
            double gallon = volume.VolumeComverter(QuantityEnums.GALLON_TO_LETER, 1);
            double liter = volume.VolumeComverter(QuantityEnums.LITER, 3.78);
            Assert.AreEqual(gallon, liter);
        }
    }
}
