using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;

namespace TopicSender
{
    /// <summary>
    /// Used to send messages to the topic 
    /// </summary>
    class Program
    {
        static string connectionString = "Endpoint=sb://manideep-servicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=Mmo3lo3rWH64UFgYyfNh+dQAE5FQkkBDgNhcAIUeAo0=";

        static string topicName = "manideeptopic";

        static ServiceBusClient client;

        static ServiceBusSender sender;

        private const int numOfMessages = 3;

        static async Task Main()
        {
            client = new ServiceBusClient(connectionString);
            sender = client.CreateSender(topicName);

            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();

            for (int i = 1; i <= numOfMessages; i++)
            {
                if (!messageBatch.TryAddMessage(new ServiceBusMessage($"Message {i}")))
                {
                    throw new Exception($"The message {i} is too large to fit in the batch.");
                }
            }

            try
            {
                await sender.SendMessagesAsync(messageBatch);
                Console.WriteLine($"A batch of {numOfMessages} messages has been published to the topic.");
            }
            finally
            {
                await sender.DisposeAsync();
                await client.DisposeAsync();
            }

            Console.WriteLine("Press any key to end the application");
            Console.ReadKey();
        }
    }
}