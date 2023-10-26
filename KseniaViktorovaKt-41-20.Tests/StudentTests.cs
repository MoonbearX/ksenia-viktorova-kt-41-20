using KseniaViktorovaKt_41_20.Models;
using KseniaViktorovaKt_41_20.Utils;
using System.Text.RegularExpressions;

namespace KseniaViktorovaKt_41_20.Tests
{
    public class StdentsTests
    {
        [Fact]
        public void IsAdult_Over18_True()
        {
            // Arrange
            var student = new Student
            {
                Name = "Иван",
                Surname = "Алекссев",
                DateBirth = DateTime.Now.AddYears(-19)
            };

            // Act
            var result = StudentUtils.IsAdult(student);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAdult_Under18_False()
        {
            // Arrange
            var student = new Student
            {
                Name = "Екатерина",
                Surname = "Андреева",
                DateBirth = DateTime.Now.AddYears(-17)
            };

            // Act
            var result = StudentUtils.IsAdult(student);

            // Assert
            Assert.False(result);
        }


        [Fact]
        public void IsValidPhoneNumber_ValidNumber_True()
        {
            // Arrange
            var phoneNumber = "+7(999)123-45-67";

            // Act
            var result = StudentUtils.IsValidPhoneNumber(phoneNumber);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidPhoneNumber_InvalidNumber_False()
        {
            // Arrange
            var phoneNumber = "+7(999)123-4567";

            // Act
            var result = StudentUtils.IsValidPhoneNumber(phoneNumber);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidEmail_ValidEmail_True()
        {
            // Arrange
            var email = "test@example.com";

            // Act
            var result = StudentUtils.IsValidEmail(email);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidEmail_InvalidEmail_False()
        {
            // Arrange
            var email = "invalid.email";

            // Act
            var result = StudentUtils.IsValidEmail(email);

            // Assert
            Assert.False(result);
        }

    }
}