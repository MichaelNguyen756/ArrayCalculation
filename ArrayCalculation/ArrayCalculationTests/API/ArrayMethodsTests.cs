using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayCalculation.API.Tests
{
    [TestClass()]
    public class ArrayMethodsTests
    {
        [TestMethod()]
        public void ReverseArrayTestSequentialNumbers()
        {
            // Arrange
            string[] normalArray = new string[] { "1", "2", "3" };
            string[] expectedArray = new string[] { "3", "2", "1" };

            // Act
            string[] testedArray = ArrayMethods.ReverseArray(normalArray);

            // Assert
            CollectionAssert.AreEqual(expectedArray, testedArray);
        }

        [TestMethod()]
        public void TryToReverseEmptyArray()
        {
            // Arrange
            string[] emptyArray = new string[0];

            // Act
            string[] testedArray = ArrayMethods.ReverseArray(emptyArray);

            // Assert
            CollectionAssert.AreEqual(emptyArray, testedArray);
        }

        [TestMethod()]
        public void DeleteArrayAtIndexTestNormalIndexOne()
        {
            // Arrange
            string[] normalArray = new string[] { "1", "2", "3" };
            string[] expectedArray = new string[] { "1", "3" };

            // Act
            string[] testedArray = ArrayMethods.DeleteArrayAtIndex(normalArray, 1);

            // Assert
            CollectionAssert.AreEqual(expectedArray, testedArray);
        }

        [TestMethod()]
        public void DeleteArrayAtIndexOfArrayLength()
        {
            // Arrange
            string[] normalArray = new string[] { "1", "2", "3" };
            string[] expectedArray = new string[] { "1", "2" };

            // Act
            string[] testedArray = ArrayMethods.DeleteArrayAtIndex(normalArray, normalArray.Length - 1);

            // Assert
            CollectionAssert.AreEqual(expectedArray, testedArray);
        }

        [TestMethod()]
        public void TryToParseIllegalIndexToDeleteButReturnsOriginalArray()
        {
            // Arrange
            string[] normalArray = new string[] { "1", "2", "3", "4" };

            // Act
            string[] testedArray = ArrayMethods.DeleteArrayAtIndex(normalArray, 5);

            // Assert
            CollectionAssert.AreEqual(normalArray, testedArray);
        }

        [TestMethod()]
        public void TryToParseIllegalIndexOfArrayLengthToDeleteButReturnsOriginalArray()
        {
            // Arrange
            string[] normalArray = new string[] { "1", "2", "3", "4" };

            // Act
            string[] testedArray = ArrayMethods.DeleteArrayAtIndex(normalArray, normalArray.Length);

            // Assert
            CollectionAssert.AreEqual(normalArray, testedArray);
        }
    }
}