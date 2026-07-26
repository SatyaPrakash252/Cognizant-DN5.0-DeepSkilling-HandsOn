using Confluent.Kafka;

string broker = "localhost:9092";
string topic = "chat-topic";

Console.WriteLine("1. Producer");
Console.WriteLine("2. Consumer");

Console.Write("Choose: ");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    var config = new ProducerConfig
    {
        BootstrapServers = broker
    };

    using var producer =
        new ProducerBuilder<Null, string>(config).Build();

    Console.WriteLine("Type messages (type exit to stop)");

    while (true)
    {
        string message = Console.ReadLine();

        if (message.ToLower() == "exit")
            break;

        producer.Produce(topic,
            new Message<Null, string>
            {
                Value = message
            });

        Console.WriteLine("Sent : " + message);
    }
}
else
{
    var config = new ConsumerConfig
    {
        BootstrapServers = broker,
        GroupId = "chat-group",
        AutoOffsetReset = AutoOffsetReset.Earliest
    };

    using var consumer =
        new ConsumerBuilder<Ignore, string>(config).Build();

    consumer.Subscribe(topic);

    Console.WriteLine("Waiting for messages...");

    while (true)
    {
        var result = consumer.Consume();

        Console.WriteLine("Received : " + result.Message.Value);
    }
}