namespace ReadingFileAsynchronously
{
    internal class Program
    {
        static async Task ReadFileAsync(String path)
        {
            String content = await File.ReadAllTextAsync(path);
            Console.WriteLine("File contents:");
            Console.WriteLine(content);
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Reading file...");
            await ReadFileAsync("D:\\dotnet\\AsyncAwait\\ReadingFileAsynchronously\\sample.txt");
            Console.WriteLine("Done!");
        }
    }
}
