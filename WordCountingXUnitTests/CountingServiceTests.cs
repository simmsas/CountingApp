using FluentAssertions;
using Moq;
using WordCountingApp.Models;
using WordCountingApp.Services;
using Xunit;

namespace WordCountingXUnitTests
{
    public class CountingServiceTests
    {
        [Fact]
        public void GetResult_GivenSampleText_ReadAndCalculateCorrectly()
        {
            Mock<IFileService> fileServiceMock = new Mock<IFileService>();
            fileServiceMock.Setup(fs => fs.ReadInputText())
                .Returns("Hello");
            fileServiceMock.Setup(fs => fs.ReadTextNumbers())
                .Returns("score 55 - 2");

            MathService mathService = new MathService();

            CountingService countingService = new CountingService(fileServiceMock.Object, mathService);

            var result = countingService.GetResult();
            result.Should().BeEquivalentTo( 
                new Result
                {
                    CharacterCount = 5,
                    WordCount = 1,
                    NumbersCount = 3
               
                });
        }

        [Fact]
        public void CountChars_GivenSampleText_CalculateCharsCorrectly()
        {
            MathService mathService = new MathService();
            
            string text = "hello";
            int number = mathService.CountChars(text);
            number.Should().Be(5);

        }
        [Fact]
        public void CountWords_GivenSampleText_CalculateWordsCorrectly()
        {

            MathService mathService = new MathService();

            string text = "hello world";


            int number = mathService.CountWords(text);

            number.Should().Be(2);

        }

        [Fact]
        public void CountNumberChars_GivenSampleText_TextReadingWork()
        {

            MathService mathService = new MathService();

            string text = "Result 55 - 45";


            int number = mathService.CountNumberChars(text);

            number.Should().Be(4);

        }
    }
}