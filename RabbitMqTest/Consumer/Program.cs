// See https://aka.ms/new-console-template for more information
using Entity;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

Console.WriteLine("Hello, World!");
var factory = new ConnectionFactory() { HostName = "localhost", UserName = "admin", Password = "123456" };
using (IConnection connection = factory.CreateConnection())
using (IModel channel = connection.CreateModel())
{
    channel.QueueDeclare(queue: "Deneme",
        durable: false,
        exclusive: false,
        autoDelete: false,
        arguments: null);
    var consumer = new EventingBasicConsumer(channel);
    consumer.Received += (model, ea) =>
    {
        var body = ea.Body;
        var message = Encoding.UTF8.GetString(body.ToArray());
        Person person = JsonConvert.DeserializeObject<Person>(message);
        Console.WriteLine($"Adı: {person.Name} Soyadı: {person.Surname} [{person.Message}]");
    };
    channel.BasicConsume(queue: "Deneme",
        consumer: consumer);
    Console.WriteLine("işe alındınız teşekkürler");
}
