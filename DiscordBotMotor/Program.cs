using System.Text;
using Discord;
using Discord.WebSocket;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// .env dosyasını yükleyin
Env.Load();

// UTF-8 Kodlaması
Console.OutputEncoding = Encoding.UTF8;

// Çevresel değişkenlerden bot token ve API base URL'sini alın
var botToken = Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");

// appsettings.json'dan yapılandırmaları alalım
var configuration = builder.Configuration;
var apiBaseUrl = configuration["DiscordBot:ApiBaseUrl"];

// Discord botu başlatma işlemi
var config = new DiscordSocketConfig
{
    GatewayIntents = GatewayIntents.Guilds | GatewayIntents.GuildMessages | GatewayIntents.DirectMessages | GatewayIntents.MessageContent
};

var client = new DiscordSocketClient(config);
var httpClient = new HttpClient
{
    BaseAddress = new Uri(apiBaseUrl)
};

client.Log += LogAsync;
client.Ready += ReadyAsync;
client.MessageReceived += MessageReceivedAsync;

async Task LogAsync(LogMessage log)
{
    Console.WriteLine(log);
}

async Task ReadyAsync()
{
    Console.WriteLine($"{client.CurrentUser} is connected!");
}

async Task MessageReceivedAsync(SocketMessage message)
{
    if (message.Author.IsBot) return;

    Console.WriteLine($"Received message: {message.Content} in channel: {message.Channel.Name}");

    if (message.Content == "/yâHak")
    {
        try
        {
            var response = await httpClient.GetStringAsync("/yâHak");
            await message.Channel.SendMessageAsync(response);
            Console.WriteLine($"Sent response: {response}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending message in {message.Channel.Name}: {ex.Message}");
        }
    }
}

await client.LoginAsync(TokenType.Bot, botToken);
await client.StartAsync();

await Task.Delay(-1);

var app = builder.Build();
app.Run();
