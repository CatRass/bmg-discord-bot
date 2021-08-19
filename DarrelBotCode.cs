using Discord;
using Discord.WebSocket;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BMGBotLocalCopy
{
	public class Program
	{
		private DiscordSocketClient _client;

		public static void Main(string[] args)
			=> new Program().MainAsync().GetAwaiter().GetResult();

		public async Task MainAsync()
		{
			_client = new DiscordSocketClient();
			_client.MessageReceived += CommandHandler;
			_client.Log += Log;

			var token = "Token here :D";

			// Some alternative options would be to keep your token in an Environment Variable or a standalone file.
			// var token = File.ReadAllText("token.txt");

			await _client.LoginAsync(TokenType.Bot, token);
			await _client.StartAsync();

			await Task.Delay(-1);
		}

		private Task Log(LogMessage msg)
		{
			Console.WriteLine(msg.ToString());
			return Task.CompletedTask;
		}

		private Task CommandHandler(SocketMessage message)
		{

			// Removes Prefix for processing
			string command = "";
			int lengthOfCommand = -1;

			// Prefix Filter
			if (!message.Content.StartsWith('!'))           // PREFIX : CHANGE LATER
				return Task.CompletedTask;

			// Ignores Commands from Bots
			if (message.Author.IsBot)
				return Task.CompletedTask;


			if (message.Content.Contains(" "))
				lengthOfCommand = message.Content.IndexOf(" ");
			else
				lengthOfCommand = message.Content.Length;
			command = message.Content.Substring(1, lengthOfCommand - 1);


			// Test command, "!hello"
			if (command.Equals("hello"))
			{
				message.Channel.SendMessageAsync($@"Hi {message.Author.Mention}, I'm BMG Bot! Go shit yourself!");
			}
			else if (command.Equals("links"))
            {

            }

				return Task.CompletedTask;
		}
	}
}
