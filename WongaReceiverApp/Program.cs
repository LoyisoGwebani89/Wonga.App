using System;
using MessageClient.Enums;
using MessageClient.Helpers;
using MessageClient.Models;
using MessageClient.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace WongaReceiver.App
{
    internal class Program
    {
        private static void Main()
        {

            Console.WriteLine("WONGA RECEIVER APP");

            var serviceProvider = GetServiceProvider();
            var messageService = serviceProvider.GetService<IMessageService>();

            //subscribe to message
            var responseModel = new MessageModel
            {
                Type = MessageType.Message,
                MessageHandler = ShowMessage
            };
            messageService.Subscribe(responseModel);

            Console.ReadLine();
        }
        private static ServiceProvider GetServiceProvider()
        {
            return new ServiceCollection()
                .AddSingleton<IAppSettings, AppSettings>()
                .AddTransient<IMessageService, MessageService>()
                .AddTransient<ILoggerFactory>(x => new LoggerFactory())
                .AddTransient<IErrorLogger, ErrorLogger<Program>>()
                .BuildServiceProvider();
        }
        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}