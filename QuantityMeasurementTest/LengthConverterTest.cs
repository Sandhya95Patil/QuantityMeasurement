
namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement.Exception;
    using QuantityMeasurement.Service;
    using static QuantityMeasurement.Enum.QuantityEnum;

    /// <summary>
    /// Tests class
    /// </summary>
    public class Tests
    {
        public LengthConverter length;
        public AddTwoValues addTwoValues;

        /// <summary>
        /// Setup the instance
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.length = new LengthConverter();
            this.addTwoValues = new AddTwoValues();
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
                LengthConverter feetTwo = null;
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
                LengthConverter feetOne = new LengthConverter();
                LengthConverter feetTwo = new LengthConverter();
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
                LengthConverter feetOne = new LengthConverter();
                LengthConverter feetTwo = new LengthConverter();
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

        /// <summary>
        /// Twelve inch equal 1 feet
        /// </summary>
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
            LengthConverter inchTwo = null;
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

        /// <summary>
        /// three feet equals one yard
        /// </summary>
        [Test]
        public void Three_Feet_Equals_One_Yard()
        {
            double yardOne = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            double yardTwo = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 3);
            Assert.AreEqual(yardOne, yardTwo);
        }

        /// <summary>
        /// one feet and one yard should equal
        /// </summary>
        [Test]
        public void One_Feet_And_One_Yard_Should_Not_Equal()
        {
            double oneFeet = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            double oneYard = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            Assert.AreNotEqual(oneFeet, oneYard);
        }

        /// <summary>
        /// one inch and one yard should equal
        /// </summary>
        [Test]
        public void One_Inch_And_One_Yard_Should_Not_Equal()
        {
            double oneInch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            double yardInInch = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            Assert.AreNotEqual(oneInch, yardInInch);
        }

        /// <summary>
        /// one yard and thirty six inch should equal
        /// </summary>
        [Test]
        public void One_Yard_And_36Inch_Should_Equal()
        {
            double oneYard = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            double yardInInch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 36);
            Assert.AreEqual(oneYard, yardInInch);
        }

        /// <summary>
        /// thirty six inch and one yard should equal
        /// </summary>
        [Test]
        public void Given36_Inch_And_One_Yard_Should_Equal()
        {
            double inch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 36);
            double yardInInch = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            Assert.AreEqual(inch, yardInInch);
        }

        /// <summary>
        /// one yard and 3 feet should equal
        /// </summary>
        [Test]
        public void One_Yard_And_3Feet_Should_Equal()
        {
            double yard = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            double feet = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 3);
            Assert.AreEqual(yard, feet);
        }

        /// <summary>
        /// Two inch and five cm should equal
        /// </summary>
        [Test]
        public void Two_Inch_And_5CM_Should_Equal()
        {
            double cm = length.ConvertValueInDifferentUnit(QuantityEnums.CM, 5);
            double inch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH_TO_CENTIMETER, 2);
            Assert.AreEqual(cm, inch);
        }

        /// <summary>
        /// 2inch + 2inch should equal 4inch
        /// </summary>
        [Test]
        public void Two_Plus_Two_Equal_Four_Inch_Should_Equal()
        {
            double addTwoValue = addTwoValues.AddTwoValue(2, 2);
            double expectedValue = 4;
            Assert.AreEqual(expectedValue, addTwoValue);
        }

        /// <summary>
        /// Two feet plus two inch should equal fourtine inch
        /// </summary>
        [Test]
        public void TwoFeet_Plus_TwoInch_Should_Equal_14Inch()
        {
            double feetInInch = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            double addTwoValue = addTwoValues.AddTwoValue(feetInInch, 2);
            double expectedValue = 14;
            Assert.AreEqual(expectedValue, addTwoValue);
        }

        /// <summary>
        /// one feet plus one feet should equal twentyfour
        /// </summary>
        [Test]
        public void OneFeet_Plus_OneFeet_Should_Equal_24Inch()
        {
            double feetInInch = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 2);
            double expectedValue = 24;
            Assert.AreEqual(expectedValue, feetInInch);
        }

        /// <summary>
        /// two inch plus 2.5 cm should equal 3Inch
        /// </summary>
        [Test]
        public void TwoInch_Plus_2_5CM_Should_Equal_3Inch()
        {
            double inch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 2);
            double cmToInch = length.ConvertValueInDifferentUnit(QuantityEnums.CENTIMETER_TO_INCH, 2.5);
            double addTwoValue = addTwoValues.AddTwoValue(inch, cmToInch);
            double expectedValue = 3;
            Assert.AreEqual(expectedValue, addTwoValue);
        }
    }
}