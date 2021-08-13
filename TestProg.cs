<<<<<<< HEAD
public class Program
{
	private DiscordSocketClient _client;

	public static void Main(string[] args)
		=> new Program().MainAsync().GetAwaiter().GetResult();

	public async Task MainAsync()
	{
		_client = new DiscordSocketClient();
		_client.Log += Log;
		await _client.LoginAsync(TokenType.Bot,
		// Removed Token	- Darrel
			Environment.GetEnvironmentVariable("Token Here"));
		await _client.StartAsync();

		// Block this task until the program is closed.
		await Task.Delay(-1);
	}
	private Task Log(LogMessage msg)
	{
		Console.WriteLine(msg.ToString());
		return Task.CompletedTask;
	}
=======
public class Program
{
	private DiscordSocketClient _client;

	public static void Main(string[] args)
		=> new Program().MainAsync().GetAwaiter().GetResult();

	public async Task MainAsync()
	{
		_client = new DiscordSocketClient();
		_client.Log += Log;
		await _client.LoginAsync(TokenType.Bot,
		// Removed Token	- Darrel
			Environment.GetEnvironmentVariable("Token Here"));
		await _client.StartAsync();

		// Block this task until the program is closed.
		await Task.Delay(-1);
	}
	private Task Log(LogMessage msg)
	{
		Console.WriteLine(msg.ToString());
		return Task.CompletedTask;
	}
>>>>>>> b169a29e1607c8f61315e5128a0751492c3c8879
}
