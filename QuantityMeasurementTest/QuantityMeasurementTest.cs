using NUnit.Framework;
using QuantityMeasurement.Exception;
using QuantityMeasurement.Service;

namespace QuantityMeasurementTest
{
    public class Tests
    {
        public Length length;

        [SetUp]
        public void Setup()
        {
            this.length = new Length();

        }

        /// <summary>
        /// Zero feet & zero feet should return equal
        /// </summary>
        [Test]
        public void Zero_Feet_And_Zero_Feet_Should_Return_Equal()
        {
            try
            {
                double feetOne = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 0.0);
                double feetTwo = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 0.0);
                Assert.AreEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// Check 0 & null should not equal
        /// </summary>
        [Test]
        public void Zero_And_Null_Should_Not_Equal()
        {
            try
            {
                double feetOne = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 0.0);
                Length feetTwo = null;
                Assert.AreNotEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// Check two different references should return false
        /// </summary>
        [Test]
        public void Two_Different_Reference_Should_Return_False()
        {
            try
            {
                Length feetOne = new Length();
                Length feetTwo = new Length();
                bool areEqual = ReferenceEquals(feetOne, feetTwo);
                Assert.IsFalse(areEqual);
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// One object assign to another object should return true
        /// </summary>
        [Test]
        public void One_Object_Assign_To_Another_Object_Should_Return_True()
        {
            try
            {
                Length feetOne = new Length();
                Length feetTwo = new Length();
                feetTwo = feetOne;
                bool areEqual = ReferenceEquals(feetOne, feetTwo);
                Assert.IsTrue(areEqual);
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }


        /// <summary>
        /// Check type of two object should return true
        /// </summary>
        [Test]
        public void Check_Type_Of_Two_Object_Should_Return_True()
        {
            try
            {
                double feetOne = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 0.0);
                double feetTwo = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 0.0);
                Assert.AreEqual(feetOne.GetType(), feetTwo.GetType());
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// One feet & two feet should return not equal
        /// </summary>
        [Test]
        public void One_Feet_And_Two_Feet_Should_Return_Not_Equal()
        {
            double feetOne = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 1);
            double feetTwo = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEET, 2);
            Assert.AreNotEqual(feetOne, feetTwo);
        }

        /// <summary>
        /// One feet & one inch should return not equal
        /// </summary>
        [Test]
        public void One_Feet_And_One_Inch_Should_Return_Not_Equal()
        {
            double feetOne = length.ConvertValueInDifferentUnit(Length.QuantityEnum.FEETTOINCH, 1);
            double feetTwo = length.ConvertValueInDifferentUnit(Length.QuantityEnum.INCH, 1);
            Assert.AreNotEqual(feetOne, feetTwo);
        }

        /// <summary>
        /// One inch & one inch should return equal
        /// </summary>
        [Test]
        public void One_Inch_And_One_Inch()
        {
            double feetOne = length.ConvertValueInDifferentUnit(Length.QuantityEnum.INCH, 1);
            double feetTwo = length.ConvertValueInDifferentUnit(Length.QuantityEnum.INCH, 1);
            Assert.AreEqual(feetOne, feetTwo);
        }

    }
}