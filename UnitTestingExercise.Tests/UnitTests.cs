using System;
using Xunit;


namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 2, 3, 6)]
        [InlineData(2, 8, 5, 15)]
        [InlineData(20, 321, 51, 392)]
        [InlineData(2, -3, 5, 4)]
        [InlineData(18, 2, 5, 25)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(5, 4, 1)]//Add test data <-------
        [InlineData(5, 2, 3)]
        [InlineData(5, 5, 0)]
        [InlineData(10, 15, -5)]
        [InlineData(250, 100, 150)]

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 4, 20)]//Add test data <-------
        [InlineData(5, 10, 50)]
        [InlineData(12, 8, 96)]
        [InlineData(7, 6, 42)]
        [InlineData(1, 1, 1)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]//Add test data <-------
        [InlineData(36, 6, 6)]
        [InlineData(18, 2, 9)]
        [InlineData(21, 7, 3)]
        [InlineData(100, 10, 10)]
        [InlineData(45, 5, 9)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
