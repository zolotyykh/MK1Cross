namespace MK1.Tests
{
    public class DerangementsTests
    {
        [Fact]
        public void CalculateDerangements_N1_Returns0()
        {
            // Arrange
            int n = 1;

            // Act
            long result = Derangements.CalculateDerangements(n);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateDerangements_N2_Returns1()
        {
            // Arrange
            int n = 2;

            // Act
            long result = Derangements.CalculateDerangements(n);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void CalculateDerangements_N3_Returns2()
        {
            // Arrange
            int n = 3;

            // Act
            long result = Derangements.CalculateDerangements(n);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void CalculateDerangements_N4_Returns9()
        {
            // Arrange
            int n = 4;

            // Act
            long result = Derangements.CalculateDerangements(n);

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void CalculateDerangements_N5_Returns44()
        {
            // Arrange
            int n = 5;

            // Act
            long result = Derangements.CalculateDerangements(n);

            // Assert
            Assert.Equal(44, result);
        }
    }
}
