using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumSubarray.Tests {
    [TestClass]
    public class SolutionTests {

        [TestMethod]
        public void Run_Array_MaximumSum() {
            // Arrange
            var numbers = new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
            const int expectedResult = 6;
            // Act
            var actualResult = Solution.Run(numbers);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Run_ValidArray_ValidAnswer() {
            // Arrange
            var numbers = new[] {-1, -2, -3, -4, -5, -6, -7, -8, 99};
            const int expectedResult = 99;
            // Act
            var actualResult = Solution.Run(numbers);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}