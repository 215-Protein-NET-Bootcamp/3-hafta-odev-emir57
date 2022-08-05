// See https://aka.ms/new-console-template for more information
using Entity;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

Console.WriteLine("Hello, World!");
Person person = new() { Name = "Emir", Surname = "Gürbüz", BirthDate = new DateTime(2002, 9, 8), Message = "lorem5" };
var factory = new ConnectionFactory() { HostName = "localhost", Password = "123456", UserName = "admin" };
using (IConnection connection = factory.CreateConnection())
using (IModel channel = connection.CreateModel())
{
    channel.QueueDeclare(queue: "Deneme",
        durable: false, exclusive: false, autoDelete: false, arguments: null);
    string message = JsonConvert.SerializeObject(person);
    var body = Encoding.UTF8.GetBytes(message);
    channel.BasicPublish(exchange: "",
        routingKey: "Deneme",
        basicProperties: null,
        body: body);
    Console.WriteLine($"Gönderilen kişi {person.Name} {person.Surname}");
}
Console.WriteLine("İlgili kişi gönderildi");
