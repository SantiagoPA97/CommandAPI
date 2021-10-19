using System;
using Xunit;
using CommandAPI.Models;
namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        public Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Act
            testCommand.HowTo = "Execute Unit Tests";
            
            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Act
            testCommand.Platform = "Execute Unit Tests";
            
            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Act
            testCommand.CommandLine = "Execute Unit Tests";
            
            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.CommandLine);
        }

        public void Dispose()
        {
            testCommand = null;
        }
    }
}