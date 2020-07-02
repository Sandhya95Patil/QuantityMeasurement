//-----------------------------------------------------------------------
// <copyright file="Tests.cs" company="BridgeLabz">
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
    /// Tests class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// create field for length 
        /// </summary>
        public Length length;

        /// <summary>
        /// create field for add two values
        /// </summary>
        public Adition addTwoValues;

        /// <summary>
        /// Set the instances
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.length = new Length();
            this.addTwoValues = new Adition();
        }

        /// <summary>
        /// Zero feet and zero feet should return equal
        /// </summary>
        [Test]
        public void Zero_Feet_And_Zero_Feet_Should_Return_Equal()
        {
                double feetOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 0.0);
                Assert.AreEqual(expected:0, feetOne);
        }

        /// <summary>
        /// Check 0 and null should not equal
        /// </summary>
        [Test]
        public void Zero_And_Null_Should_Not_Equal()
        {
                double feetOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 0.0);
                Length feetTwo = null;
                Assert.AreNotEqual(feetOne, feetTwo);
        }

        /// <summary>
        /// Check two different references should return false
        /// </summary>
        [Test]
        public void Two_Different_Reference_Should_Return_False()
        {
            Length reference1 = new Length();
            Length reference2 = new Length();
            bool areEqual = ReferenceEquals(reference1, reference2);
            Assert.IsFalse(areEqual);
        }
       
        // <summary>
        /// One object assign to another object should return true
        /// </summary>
        [Test]
        public void Given_One_Object_Assign_To_Another_Object_Should_Return_True()
        {
                Length reference1 = new Length();
                Length reference2 = reference1;
                bool areEqual = ReferenceEquals(reference1, reference2);
                Assert.IsTrue(areEqual);
        }


        /// <summary>
        /// Check type of two object should return true
        /// </summary>
        [Test]
        public void Check_Type_Of_Two_Object_Should_Return_True()
        {
                double feetOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 0.0);
                double feetTwo = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 0.0);
                Assert.AreEqual(feetOne.GetType(), feetTwo.GetType());
        }

        /// <summary>
        /// One feet and two feet should return not equal
        /// </summary>
        [Test]
        public void Given_One_Feet_And_Two_Feet_Should_Return_Not_Equal()
        {
            double feetOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET, 2);
            Assert.AreNotEqual(1,feetOne);
        }

        /// <summary>
        /// One feet and one inch should return not equal
        /// </summary>
        [Test]
        public void Given_One_Feet_And_One_Inch_Should_Return_Not_Equal()
        {
            double feetTwoInch = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            double inchOne = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            Assert.AreNotEqual(feetTwoInch, inchOne);
        }

        /// <summary>
        /// One inch and one feet should return not equal
        /// </summary>
        [Test]
        public void Given_One_Inch_And_One_Feet_Should_Return_Not_Equal()
        {
            double inch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            double feet = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            Assert.AreNotEqual(inch, feet);
        }

        /// <summary>
        /// One feet equal to 12 inch shouls return equal
        /// </summary>
        [Test]
        public void Given_One_Feet_Equals_12Inch()
        {
            double feet = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            double inch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 12);
            Assert.AreEqual(feet, inch);
        }

        /// <summary>
        /// Twelve inch equals 1feet
        /// </summary>
        [Test]
        public void Given_Twelve_Inch_Equals_1Feet()
        {
            double feet = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            Assert.AreEqual(expected: 12, feet);
        }

        /// <summary>
        /// One inch and one inch should return equal
        /// </summary>
        [Test]
        public void Given_One_Inch_And_One_Inch_Should_Return_Equal()
        {
            double inchTwo = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            Assert.AreEqual(expected: 1, inchTwo);
        }

        /// <summary>
        /// Zero inch and null should not equal
        /// </summary>
        [Test]
        public void Given_Zero_Inch_And_Null_Should_Not_Equal()
        {
            double inchOne = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            Length inchTwo = null;
            Assert.AreNotEqual(inchOne, inchTwo);
        }

        /// <summary>
        /// one inch and 12 inch should not equal
        /// </summary>
        [Test]
        public void Given_One_Inch_And_12_Inch_Should_Not_Equal()
        {
            double inchOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1.0);
            Assert.AreNotEqual(expected: 1, inchOne);
        }

        /// <summary>
        /// zero yard and zero yard should return equal
        /// </summary>
        [Test]
        public void Given_Zero_Yard_And_Zero_Yard_Should_Equal()
        {
            double yardOne = length.ConvertValueInDifferentUnit(QuantityEnums.YARD, 0.0);
            double yardTwo = length.ConvertValueInDifferentUnit(QuantityEnums.YARD, 0.0);
            Assert.AreEqual(yardOne, yardTwo);
        }

        /// <summary>
        /// one yard and one feet should return not equal 
        /// </summary>
        [Test]
        public void Given_One_Yard_And_One_Feet_Should_Not_Equal()
        {
            double yardOne = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            double yardTwo = length.ConvertValueInDifferentUnit(QuantityEnums.YARD, 1);
            Assert.AreNotEqual(yardOne, yardTwo);
        }

        /// <summary>
        /// One yard and one inch should not equal
        /// </summary>
        [Test]
        public void Given_One_Yard_And_One_Inch_Should_Not_Equal()
        {
            double yardOne = length.ConvertValueInDifferentUnit(QuantityEnums.YARD, 1);
            double yardToInch = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            Assert.AreNotEqual(yardOne, yardToInch);
        }

        /// <summary>
        /// three feet equals one yard
        /// </summary>
        [Test]
        public void Given_Three_Feet_Equals_One_Yard()
        {
            double yardOne = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            double yardTwo = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 3);
            Assert.AreEqual(yardOne, yardTwo);
        }

        /// <summary>
        /// one feet and one yard should not equal
        /// </summary>
        [Test]
        public void Given_One_Feet_And_One_Yard_Should_Not_Equal()
        {
            double oneFeet = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            double oneYard = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            Assert.AreNotEqual(oneFeet, oneYard);
        }

        /// <summary>
        /// one inch and one yard should not equal
        /// </summary>
        [Test]
        public void Given_One_Inch_And_One_Yard_Should_Not_Equal()
        {
            double oneInch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 1);
            double yardInInch = length.ConvertValueInDifferentUnit(QuantityEnums.YARD_TO_INCH, 1);
            Assert.AreNotEqual(oneInch, yardInInch);
        }

        /// <summary>
        /// one yard and thirty six inch should equal
        /// </summary>
        [Test]
        public void Given_One_Yard_And_36Inch_Should_Equal()
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
        public void Given_Two_Inch_And_5CM_Should_Equal()
        {
            double cm = length.ConvertValueInDifferentUnit(QuantityEnums.INCH_TO_CENTIMETER, 2);
            Assert.AreEqual(5, cm);
        }

        /// <summary>
        /// 2inch + 2inch should equal 4inch
        /// </summary>
        [Test]
        public void Given_Two_Plus_Two_Equal_Four_Inch_Should_Equal()
        {
            double inch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 2);
            double addTwoValue = addTwoValues.AddTwoValue(inch, inch);
            Assert.AreEqual(expected: 4, addTwoValue);
        }

        /// <summary>
        /// Two feet plus two inch should equal fourtine inch
        /// </summary>
        [Test]
        public void Given_TwoFeet_Plus_TwoInch_Should_Equal_14Inch()
        {
            double feetInInch = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 1);
            double result = addTwoValues.AddTwoValue(feetInInch, 2);
            Assert.AreEqual(expected: 14, result);
        }

        /// <summary>
        /// one feet plus one feet should equal twentyfour
        /// </summary>
        [Test]
        public void Given_OneFeet_Plus_OneFeet_Should_Equal_24Inch()
        {
            double feetInInch = length.ConvertValueInDifferentUnit(QuantityEnums.FEET_TO_INCH, 2);
            Assert.AreEqual(expected: 24, feetInInch);
        }

        /// <summary>
        /// two inch plus 2.5 cm should equal 3Inch
        /// </summary>
        [Test]
        public void Given_TwoInch_Plus_2_5CM_Should_Equal_3Inch()
        {
            double inch = length.ConvertValueInDifferentUnit(QuantityEnums.INCH, 2);
            double cmToInch = length.ConvertValueInDifferentUnit(QuantityEnums.CENTIMETER_TO_INCH, 2.5);
            double result = addTwoValues.AddTwoValue(inch, cmToInch);
            Assert.AreEqual(expected: 3, result);
        }

        /// <summary>
        /// Given feet and liter when compared should throw exception
        /// </summary>
        [Test]
        public void Given_Liter_In_Length_Method_Then_Should_Throw_Exception()
        {
            try
            {
               length.ConvertValueInDifferentUnit(QuantityEnums.LITER, 1);
            }
            catch(QuantityException e)
            {
               Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }

        /// <summary>
        /// Given kilogram in length method then should throw exception
        /// </summary>
        [Test]
        public void Given_Kilogram_In_Length_Method_Then_Should_Throw_Exception()
        {
            try
            {
                length.ConvertValueInDifferentUnit(QuantityEnums.KILOGRAM, 1);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }

        /// <summary>
        /// Given celsius in length method then should throw exception
        /// </summary>
        [Test]
        public void Given_Celsius_In_Length_Method_Then_Should_Throw_Exception()
        {
            try
            {
                length.ConvertValueInDifferentUnit(QuantityEnums.CELSIUS, 1);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }

        /// <summary>
        /// Given farenheit in length method then should throw exception
        /// </summary>
        [Test]
        public void Given_Farenheit_In_Length_Method_Then_Should_Throw_Exception()
        {
            try
            {
                length.ConvertValueInDifferentUnit(QuantityEnums.FAHRENHEIT, 1);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }

        /// <summary>
        /// Given centimeter in length method then should throw exception
        /// </summary>
        [Test]
        public void Given_Centimeter_In_Length_Method_Then_Should_Throw_Exception()
        {
            try
            {
                length.ConvertValueInDifferentUnit(QuantityEnums.CM, 1);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.QUANTITY_UNEQUALITY, e.EType);
            }
        }
    }
}