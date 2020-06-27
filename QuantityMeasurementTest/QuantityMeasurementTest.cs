using NUnit.Framework;
using QuantityMeasurement.Exception;
using QuantityMeasurement.Service;
using static QuantityMeasurement.Enum.QuantityEnum;

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
        /// Zero feet and zero feet should return equal
        /// </summary>
        [Test]
        public void Zero_Feet_And_Zero_Feet_Should_Return_Equal()
        {
            try
            {
                double feetOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 0.0);
                double feetTwo = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 0.0);
                Assert.AreEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// Check 0 and null should not equal
        /// </summary>
        [Test]
        public void Zero_And_Null_Should_Not_Equal()
        {
            try
            {
                double feetOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 0.0);
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
                double feetOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 0.0);
                double feetTwo = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 0.0);
                Assert.AreEqual(feetOne.GetType(), feetTwo.GetType());
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// One feet and two feet should return not equal
        /// </summary>
        [Test]
        public void One_Feet_And_Two_Feet_Should_Return_Not_Equal()
        {
            double feetOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 1);
            double feetTwo = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 2);
            Assert.AreNotEqual(feetOne, feetTwo);
        }

        /// <summary>
        /// One feet and one inch should return not equal
        /// </summary>
        [Test]
        public void One_Feet_And_One_Inch_Should_Return_Not_Equal()
        {
            double feetTwoInch = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            double inchOne = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            Assert.AreNotEqual(feetTwoInch, inchOne);
        }

        /// <summary>
        /// One inch and one feet should return not equal
        /// </summary>
        [Test]
        public void One_Inch_And_One_Feet_Should_Return_Not_Equal()
        {
            double inch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            double feet = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            Assert.AreNotEqual(inch, feet);
        }

        /// <summary>
        /// One feet equal to 12 inch shouls return equal
        /// </summary>
        [Test]
        public void One_Feet_Equals_12Inch()
        {
            double feet = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            double inch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 12);
            Assert.AreEqual(feet, inch);
        }

        [Test]
        public void Twelve_Inch_Equals_1Feet()
        {
            double inch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 12);
            double feet = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            Assert.AreEqual(inch, feet);
        }

        /// <summary>
        /// One inch and one inch should return equal
        /// </summary>
        [Test]
        public void One_Inch_And_One_Inch_Should_Return_Equal()
        {
            double inchOne = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            double inchTwo = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            Assert.AreEqual(inchOne, inchTwo);
        }

        /// <summary>
        /// Zero inch and null should not equal
        /// </summary>
        [Test]
        public void Zero_Inch_And_Null_Should_Not_Equal()
        {
            double inchOne = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            Length inchTwo = null;
            Assert.AreNotEqual(inchOne, inchTwo);
        }

        /// <summary>
        /// one inch and 12 inch should not equal
        /// </summary>
        [Test]
        public void One_Inch_And_12_Inch_Should_Not_Equal()
        {
            double inchOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1.0);
            double inchTwo = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1.0);
            Assert.AreNotEqual(inchOne, inchTwo);
        }

        /// <summary>
        /// zero yard and zero yard should return equal
        /// </summary>
        [Test]
        public void Zero_Yard_And_Zero_Yard_Should_Equal()
        {
            double yardOne = length.ConvertValueInDifferentUnit(QuantityEnums.YARD, 0.0);
            double yardTwo = length.ConvertValueInDifferentUnit(QuantityEnums.YARD, 0.0);
            Assert.AreEqual(yardOne, yardTwo);
        }

        /// <summary>
        /// one yard and one feet should return not equal 
        /// </summary>
        [Test]
        public void One_Yard_And_One_Feet_Should_Not_Equal()
        {
            double yardOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            double yardTwo = length.ConvertValueInDifferentUnit(QuantityEnums.YARD, 1);
            Assert.AreNotEqual(yardOne, yardTwo);
        }

        /// <summary>
        /// One yard and one inch should not equal
        /// </summary>
        [Test]
        public void One_Yard_And_One_Inch_Should_Not_Equal()
        {
            double yardOne = length.ConvertValueInDifferentUnit(QuantityEnums.YARD, 1);
            double yardTwo = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            Assert.AreNotEqual(yardOne, yardTwo);
        }

        [Test]
        public void Three_Feet_Equals_One_Yard()
        {
            double yardOne = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            double yardTwo = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 3);
            Assert.AreEqual(yardOne, yardTwo);
        }

    }
}