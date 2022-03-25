using WordCountingApp.Models;

namespace WordCountingApp.Services
{
    public class CountingService
    {
        IFileService fileService;
        MathService mathService;

        public CountingService(IFileService fileService, MathService mathService)
        {
            this.fileService = fileService;
            this.mathService = mathService;
        }

        public Result GetResult()
        {
            string text = fileService.ReadInputText();
            string textNumbers = fileService.ReadTextNumbers();

            int characterCount = mathService.CountChars(text);
            int wordCount = mathService.CountWords(text);
            int numbersCount = mathService.CountNumberChars(textNumbers);

            return new Result
            {
                CharacterCount = characterCount,
                WordCount = wordCount,
                NumbersCount = numbersCount
            };
        }

        public void Count()
        {
            var result = GetResult();

            Console.WriteLine($"Characters in file: {result.CharacterCount}");

            Console.WriteLine($"Words in file: {result.WordCount}") ;

            Console.WriteLine($"Number characters in file: {result.NumbersCount}") ;
        }

        

    }
}
