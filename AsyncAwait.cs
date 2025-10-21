namespace AsyncAwait
{
    internal class Program
    {

        // Async method returning a Task
        static async Task DisplayMessageAsync()
        {
            await Task.Delay(2000);  // Wait for 2 seconds (simulates work)
            Console.WriteLine("Hello from async method!");
        }
        static async Task Main1(string[] args)
        {
            Console.WriteLine("Before calling async method...");
            await DisplayMessageAsync();  // Await the async method
            Console.WriteLine("After async method finishes.");
        }

        // Async Method with Return Value
        static async Task<int> GetNumberAsync()
        {
            await Task.Delay(1000);  // Simulate delay
            return 42;  // Return value
        }

        static async Task Main2()
        {
            Console.WriteLine("Fetching number...");
            int result = await GetNumberAsync();
            Console.WriteLine($"Received: {result}");
        }
    }
}
