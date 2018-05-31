using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindTheSingleton.Tests {
    [TestClass]
    public class SolutionTests {
        [TestMethod]
        public void Run_EmptyList_0() {
            // Arrange
            var students = new int[0];
            const int expectedStudent = 0;
            // Act
            var actualStudent = Solution.Run(students);
            // Assert
            Assert.AreEqual(expectedStudent, actualStudent);
        }

        [TestMethod]
        public void Run_InvalidList_0() {
            // Arrange
            var students = new[] {2, 4, 5, 5, 4, 2};
            const int expectedStudent = 0;
            // Act
            var actualStudent = Solution.Run(students);
            // Assert
            Assert.AreEqual(expectedStudent, actualStudent);
        }

        [TestMethod]
        public void Run_ValidList_CorrectNumber() {
            // Arrange
            var students = new[] {2, 4, 5, 4, 2};
            const int expectedStudent = 5;
            // Act
            var actualStudent = Solution.Run(students);
            // Assert
            Assert.AreEqual(expectedStudent, actualStudent);
        }
    }
}