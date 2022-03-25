namespace WordCountingApp.Services
{
    public class FileService : IFileService
    {
        public string ReadInputText()
        {
            string text = File.ReadAllText("Data/Input.txt");
            return text;
        }

        public string ReadTextNumbers()
        {
            string text = File.ReadAllText("Data/TextNumbers.txt");
            return text;
        }
    }
}
