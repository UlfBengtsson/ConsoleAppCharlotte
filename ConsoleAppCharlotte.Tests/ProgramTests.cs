using System;
using Xunit;
using ConsoleAppCharlotte;

namespace ConsoleAppCharlotte.Tests
{
    public class ProgramTests
    {
        [Fact]//Annotation - xUnit = is a test
        public void MyIdTest()
        {
            //Arrange
            int goodId = 1;
            Program program = new Program();

            //Act
            program.MyId = goodId;

            //Assert
            Assert.Equal(goodId, program.MyId);
        }
    }
}
