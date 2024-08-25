var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DiscordBotAPI>("discordbotapi");

builder.AddProject<Projects.DiscordBotMotor>("discordbotmotor");

builder.Build().Run();
